using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business.Cadastro
{
    public class PessoaBus : IPortariaBus<Pessoa>
    {
        private PortariaContext bd;

        public PessoaBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Pessoa> Todos()
        {
            return bd.Pessoas;
        }

        public Pessoa BuscaPorId(int id)
        {
            return bd.Pessoas.Where(i => i.Id == id).FirstOrDefault();
        }

        public IEnumerable<Pessoa> BuscaPorNome(string nome)
        {
            return bd.Pessoas.Where(i => i.Nome.ToUpper().Contains(nome.ToUpper()));
        }


        public void InserirOuAtualizar(Pessoa entidade)
        {
            try
            {
                var p = bd.Pessoas.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (p == null)
                {
                    bd.Pessoas.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                p.Email = entidade.Email;
                p.FoneCelular = entidade.FoneCelular;
                p.FoneComercial = entidade.FoneComercial;
                p.FoneResidencial = entidade.FoneResidencial;
                p.Foto = entidade.Foto;
                p.GrauParentesco = entidade.GrauParentesco;
                p.Nome = entidade.Nome;

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(Pessoa entidade)
        {
            try
            {
                bd.Pessoas.Remove(entidade);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
