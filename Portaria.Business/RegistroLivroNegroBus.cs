using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public class RegistroLivroNegroBus : IPortariaBus<RegistroLivroNegro>
    {
        private PortariaContext bd;

        public RegistroLivroNegroBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<RegistroLivroNegro> Todos()
        {
            return bd.RegistrosLivroNegro;
        }

        public void InserirOuAtualizar(RegistroLivroNegro entidade)
        {
            try
            {
                var r = bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == entidade.Id);
                var sessao = SessaoBus.Sessao();

                if (r == null)
                {
                    entidade.Sessao = bd.Sessoes.FirstOrDefault(i => i.Id == sessao.Id);
                    bd.RegistrosLivroNegro.Add(entidade);

                    bd.SaveChanges();
                    return;
                }

                r.Sessao = bd.Sessoes.FirstOrDefault(i => i.Id == sessao.Id);
                r.Mensagem = entidade.Mensagem;

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RegistroLivroNegro BuscaPorId(int id)
        {
            return bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(RegistroLivroNegro entidade)
        {
            try
            {
                var r = bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == entidade.Id);

                if (r != null)
                {
                    bd.RegistrosLivroNegro.Remove(r);
                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
