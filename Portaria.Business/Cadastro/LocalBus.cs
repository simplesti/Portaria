using Portaria.Core.Model.Cadastro;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Portaria.Log;

namespace Portaria.Business.Cadastro
{
    public class LocalBus : IPortariaBus<Local>
    {
        private PortariaContext bd;

        public LocalBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Local> Todos()
        {
            return bd.Locais;
        }

        public void InserirOuAtualizar(Local entidade)
        {
            try
            {
                var l = bd.Locais.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (l == null)
                {
                    bd.Locais.Add(entidade);
                    bd.SaveChanges();
                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var entidadeOriginal = PortariaLog.SerializarEntidade(l);

                l.Nome = entidade.Nome;
                l.Descricao = entidade.Descricao;

                bd.SaveChanges();

                PortariaLog.Logar(l.Id, entidadeOriginal, PortariaLog.SerializarEntidade(l), l.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Local BuscaPorId(int id)
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
                    bd.Locais.Remove(l);
                    bd.SaveChanges();

                    PortariaLog.Logar(l.Id, string.Empty, PortariaLog.SerializarEntidade(l), l.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
