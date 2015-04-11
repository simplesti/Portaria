using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using Portaria.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Portaria.Business.Cadastro
{
    public class BlocoBus : IPortariaBus<Bloco>
    {
        private PortariaContext bd;

        public BlocoBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Bloco> Todos()
        {
            return bd.Blocos;
        }

        public void InserirOuAtualizar(Bloco entidade)
        {
            try
            {
                var b = bd.Blocos.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (b == null)
                {
                    bd.Blocos.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var entidadeOriginal = PortariaLog.SerializarEntidade(b);
                
                b.Nome = entidade.Nome;

                bd.SaveChanges();

                PortariaLog.Logar(b.Id, entidadeOriginal, PortariaLog.SerializarEntidade(b), b.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Bloco BuscaPorId(int id)
        {
            return bd.Blocos.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(Bloco entidade)
        {
            try
            {
                var b = bd.Blocos.FirstOrDefault(i => i.Id == entidade.Id);

                if (b != null)
                {
                    bd.Blocos.Remove(b);
                    bd.SaveChanges();

                    PortariaLog.Logar(b.Id, string.Empty, PortariaLog.SerializarEntidade(b), b.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
