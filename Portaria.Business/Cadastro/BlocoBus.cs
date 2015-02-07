using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;

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
                var b = bd.Blocos.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (b == null)
                {
                    bd.Blocos.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                b.Nome = entidade.Nome;

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Bloco BuscaPorId(int id)
        {
            return bd.Blocos.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Remover(Bloco entidade)
        {
            try
            {
                bd.Blocos.Remove(entidade);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
