using Portaria.Core.Model.Cadastro;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Portaria.Log;
using Portaria.Core.Model;
using Portaria.Core;

namespace Portaria.Business.Cadastro
{
    public class LocalBus : IPortariaBus<Local>
    {
        private PortariaContext bd;
        private Sessao sessao;
        public LocalBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public LocalBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public IEnumerable<Local> Todos()
        {
            return bd.Locais;
        }

        public void InserirOuAtualizar(Local entidade)
        {
            try
            {
                var l = bd.Locais.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (l == null)
                {
                    if (bd.Locais.Any(q => q.Nome.ToUpper() == entidade.Nome.ToUpper()))
                    {
                        throw new Exception("Local já cadastrado com este nome.");
                    }

                    bd.Locais.Add(entidade);
                    bd.SaveChanges();
                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                if (bd.Locais.Any(q => q.Id != entidade.Id && q.Nome.ToUpper() == entidade.Nome.ToUpper()))
                {
                    throw new Exception("Local já cadastrado com este nome.");
                }

                var lo = bd.Locais.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(lo);

                l.Nome = entidade.Nome;
                l.Descricao = entidade.Descricao;

                bd.SaveChanges();

                PortariaLog.Logar(l.Id, entidadeOriginal, PortariaLog.SerializarEntidade(l), l.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Local BuscarPorId(int id)
        {
            return bd.Locais.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(Local entidade)
        {
            try
            {
                var l = bd.Locais.FirstOrDefault(i => i.Id == entidade.Id);

                if (l != null)
                {
                    var ent = PortariaLog.SerializarEntidade(l);

                    bd.Locais.Remove(l);
                    bd.SaveChanges();

                    PortariaLog.Logar(l.Id, string.Empty, ent, l.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            bd.Dispose();
        }
    }
}
