using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Portaria.Business
{
    public class RegistroLivroNegroEntidadeBus : IPortariaBus<RegistroLivroNegroEntidade>
    {
        private PortariaContext bd;
        public RegistroLivroNegroEntidadeBus()
        {
            bd = new PortariaContext();
        }

        public RegistroLivroNegroEntidadeBus(PortariaContext bd)
        {
            this.bd = bd;
        }
        
        public IEnumerable<RegistroLivroNegroEntidade> Todos()
        {
            return bd.RegistroLivroNegroEntidades;
        }

        public void InserirOuAtualizar(RegistroLivroNegroEntidade entidade)
        {
            try
            {
                var r = bd.RegistroLivroNegroEntidades.AsNoTracking().FirstOrDefault(i => i.Id == entidade.Id);

                if (r == null)
                {
                    entidade.RegistroLivroNegro = bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == entidade.RegistroLivroNegro.Id);

                    bd.RegistroLivroNegroEntidades.Add(entidade);

                    bd.SaveChanges();
                    return;
                }

                r.IdEntidade = entidade.IdEntidade;
                r.Tipo = entidade.Tipo;
                r.RegistroLivroNegro = bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == entidade.RegistroLivroNegro.Id);

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RegistroLivroNegroEntidade BuscaPorId(int id)
        {
            return bd.RegistroLivroNegroEntidades.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(RegistroLivroNegroEntidade entidade)
        {
            try
            {
                var r = bd.RegistroLivroNegroEntidades.FirstOrDefault(i => i.Id == entidade.Id);

                if (r != null)
                {
                    bd.RegistroLivroNegroEntidades.Remove(r);

                    bd.SaveChanges();
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
