using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business.Cadastro
{
    public class FuncionarioBus : IPortariaBus<Funcionario>
    {
        private PortariaContext bd;

        public FuncionarioBus()
        {
            bd = PortariaContext.BD;
        }
        public IEnumerable<Funcionario> Todos()
        {
            return bd.Funcionarios;
        }

        public void InserirOuAtualizar(Funcionario entidade)
        {
            try
            {
                var f = bd.Funcionarios.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (f == null)
                {
                    bd.Funcionarios.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                f.AutorizadaSemPresenca = entidade.AutorizadaSemPresenca;
                f.Descricao = entidade.Descricao;
                f.Fone = entidade.Fone;
                f.Documento = entidade.Documento;
                f.Foto = entidade.Foto;
                f.Frequencia = entidade.Frequencia;
                f.Nome = entidade.Nome;
                f.HorarioEntrada = entidade.HorarioEntrada;
                f.HorarioSaida = entidade.HorarioSaida;

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario BuscaPorId(int id)
        {
            return bd.Funcionarios.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Remover(Funcionario entidade)
        {
            try
            {
                bd.Funcionarios.Remove(entidade);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
