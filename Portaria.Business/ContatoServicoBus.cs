using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Data;
using Portaria.Log;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Portaria.Business
{
    public class ContatoServicoBus : IPortariaBus<ContatoServico>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public ContatoServicoBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public ContatoServicoBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public ContatoServico BuscarPorId(int id)
        {
            return bd.ContatosServicos.Where(q => q.Id == id).FirstOrDefault();
        }

        public void Dispose()
        {
            bd.Dispose();
        }

        public void InserirOuAtualizar(ContatoServico entidade)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(entidade.Nome))
                {
                    throw new Exception("O campo nome é obrigatório.");
                }

                if (string.IsNullOrWhiteSpace(entidade.Telefone))
                {
                    throw new Exception("O campo telefone é obrigatório.");
                }

                var c = bd.ContatosServicos.Where(i => i.Id == entidade.Id).FirstOrDefault();
                if (c == null)
                {
                    bd.ContatosServicos.Add(entidade);

                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                }

                var co = bd.ContatosServicos.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(co);

                c.Endereco = entidade.Endereco;
                c.Observacao = entidade.Observacao;
                c.Telefone = entidade.Telefone;
                c.Nome = entidade.Nome;

                bd.SaveChanges();

                PortariaLog.Logar(c.Id, entidadeOriginal, PortariaLog.SerializarEntidade(c), c.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(ContatoServico entidade)
        {
            try
            {
                var c = bd.ContatosServicos.FirstOrDefault(i => i.Id == entidade.Id);

                if (c != null)
                {
                    var ent = PortariaLog.SerializarEntidade(c);

                    bd.ContatosServicos.Remove(c);
                    bd.SaveChanges();

                    PortariaLog.Logar(c.Id, string.Empty, ent, c.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ContatoServico> Todos()
        {
            return bd.ContatosServicos;
        }

        public IEnumerable<ContatoServico> Pesquisar(string criterios, TipoContatoServico tipoServico)
        {
            var n = criterios.ToUpper().Split(' ');
            var retorno = new List<ContatoServico>();

            foreach (var termo in n)
            {
                var query = bd.ContatosServicos.Where(q => q.TipoServico == tipoServico &&
                                                        q.Nome.ToUpper().Contains(termo) ||
                                                        q.Observacao.ToUpper().Contains(termo) ||
                                                        q.Endereco.ToUpper().Contains(termo));

                retorno.AddRange(query.ToList());
            }

            retorno = retorno.Distinct().ToList();

            return retorno;
        }
    }
}
