using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business.Cadastro
{
    public class UnidadeBus : IPortariaBus<Unidade>
    {
        private PortariaContext bd;

        public UnidadeBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Unidade> Todos()
        {
            var u = bd.Unidades;
            foreach (var i in u)
            {
                var x = i.Proprietario;
                var z = i.Conjuge;
                var q = i.Animais;
                var w = i.Assinaturas;
                var t = i.Autorizados;
                var y = i.Funcionarios;
                var o = i.Veiculos;
            }

            return u;
        }

        public Unidade Buscar(int numero, string bloco)
        {
            return bd.Unidades.Where(i => i.Numero == numero && i.Bloco.Nome == bloco)
                .FirstOrDefault();
        }

        public IEnumerable<Unidade> BuscarPorNumero(int numero)
        {
            return bd.Unidades.Where(i => i.Numero == numero);
        }

        public IEnumerable<Unidade> BuscarPorBloco(string bloco)
        {
            return bd.Unidades.Where(i => i.Bloco.Nome == bloco);
        }

        public void InserirOuAtualizar(Unidade entidade)
        {
            try
            {
                var u = bd.Unidades.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (u == null)
                {
                    entidade.DataAtualizacao = DateTime.Now;
                    bd.Unidades.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                u.DataAtualizacao = DateTime.Now;
                u.AparelhosGas = entidade.AparelhosGas;
                u.Bloco = entidade.Bloco;
                u.Numero = entidade.Numero;

                var pessoaBus = new PessoaBus();

                if (entidade.Proprietario != null)
                {
                    u.Proprietario = pessoaBus.BuscaPorId(entidade.Proprietario.Id);
                }
                if (entidade.Locatario != null)
                {
                    u.Locatario = pessoaBus.BuscaPorId(entidade.Locatario.Id);
                }
                if (entidade.Conjuge != null)
                {
                    u.Conjuge = pessoaBus.BuscaPorId(entidade.Conjuge.Id);
                }

                u.Observacoes = entidade.Observacoes;

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Unidade BuscaPorId(int id)
        {
            return bd.Unidades.Where(i => i.Id == id).FirstOrDefault();
        }


        public void Remover(Unidade entidade)
        {
            try
            {
                bd.Unidades.Remove(entidade);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
