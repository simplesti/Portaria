using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Data;
using Portaria.Log;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public class ConfiguracaoBus : IPortariaBus<Configuracao>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public ConfiguracaoBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public ConfiguracaoBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public Configuracao BuscarPorId(int id)
        {
            return bd.Configuracoes.Where(q => q.Id == id).FirstOrDefault();
        }

        public void Dispose()
        {
            bd.Dispose();
        }

        public void InserirOuAtualizar(Configuracao entidade)
        {
            try
            {
                var c = bd.Configuracoes.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (c == null)
                {
                    if (bd.Configuracoes.Any(q => q.Nome.ToUpper() == entidade.Nome.ToUpper()))
                    {
                        throw new Exception("Configuração já cadastrada com este nome.");
                    }

                    bd.Configuracoes.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                if (bd.Configuracoes.Any(q => q.Id != entidade.Id && (q.Nome.ToUpper() == entidade.Nome.ToUpper())))
                {
                    throw new Exception("Configuração já cadastrada com este nome.");
                }

                var co = bd.Configuracoes.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(co);

                c.Nome = entidade.Nome;
                c.Valor = entidade.Valor;

                bd.SaveChanges();

                PortariaLog.Logar(c.Id, entidadeOriginal, PortariaLog.SerializarEntidade(c), c.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(Configuracao entidade)
        {
            try
            {
                var c = bd.Configuracoes.FirstOrDefault(i => i.Id == entidade.Id);

                if (c != null)
                {
                    var ent = PortariaLog.SerializarEntidade(c);

                    bd.Configuracoes.Remove(c);
                    bd.SaveChanges();

                    PortariaLog.Logar(c.Id, string.Empty, ent, c.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Configuracao> Todos()
        {
            return bd.Configuracoes;
        }

        public string BuscarValor(TipoConfiguracao configuracao)
        {
            var config = bd.Configuracoes.FirstOrDefault(q => q.Nome == configuracao.ToString());
            if (config != null)
            {
                return config.Valor;
            }

            return string.Empty;
        }

        public void SetarValor(TipoConfiguracao configuracao, string valor)
        {
            var config = bd.Configuracoes.FirstOrDefault(q => q.Nome == configuracao.ToString());
            if (config == null)
            {
                config = new Configuracao() { Nome = configuracao.ToString(), Valor = valor };
            }
            else
            {
                config.Valor = valor;
            }

            InserirOuAtualizar(config);
        }
    }
}
