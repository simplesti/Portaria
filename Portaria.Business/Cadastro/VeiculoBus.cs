using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business.Cadastro
{
    public class VeiculoBus : IPortariaBus<Veiculo>
    {
        private PortariaContext bd;

        public VeiculoBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Veiculo> Todos()
        {
            return bd.Veiculos;
        }

        public void InserirOuAtualizar(Veiculo entidade)
        {
            try
            {
                var v = bd.Veiculos.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (v == null)
                {
                    bd.Veiculos.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                v.Cor = entidade.Cor;
                v.Foto = entidade.Foto;
                v.Nome = entidade.Nome;
                v.Placa = entidade.Placa;

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Veiculo BuscaPorId(int id)
        {
            return bd.Veiculos.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Remover(Veiculo entidade)
        {
            try
            {
                bd.Veiculos.Remove(entidade);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
