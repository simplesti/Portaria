using Portaria.Core.Model.Cadastro;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                var l = bd.Locais.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (l == null)
                {
                    bd.Locais.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                l.Nome = entidade.Nome;
                l.Descricao = entidade.Descricao;

                bd.SaveChanges();
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
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
