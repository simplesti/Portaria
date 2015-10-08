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
    public class RegistroLivroNegroBus : IPortariaBus<RegistroLivroNegro>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public RegistroLivroNegroBus(Sessao sessao)
        {
            bd = PortariaContext.BD;
            this.sessao = sessao;
        }

        public IEnumerable<RegistroLivroNegro> Todos()
        {
            return bd.RegistrosLivroNegro;
        }

        public void InserirOuAtualizar(RegistroLivroNegro entidade)
        {
            try
            {
                ValidarRegistro(entidade);

                var r = bd.RegistrosLivroNegro.AsNoTracking().FirstOrDefault(i => i.Id == entidade.Id);

                if (r == null)
                {
                    entidade.Data = DateTime.Now;
                    entidade.Sessao = bd.Sessoes.FirstOrDefault(i => i.Id == sessao.Id);
                    entidade.Pessoa = bd.Pessoas.FirstOrDefault(p => p.Id == entidade.Pessoa.Id);
                    bd.RegistrosLivroNegro.Add(entidade);

                    bd.SaveChanges();
                    return;
                }

                r.Data = DateTime.Now;
                r.Pessoa = bd.Pessoas.FirstOrDefault(p => p.Id == entidade.Pessoa.Id);
                r.Sessao = bd.Sessoes.FirstOrDefault(i => i.Id == sessao.Id);
                r.Mensagem = entidade.Mensagem;

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ValidarRegistro(RegistroLivroNegro entidade)
        {
            if (entidade.Pessoa == null)
            {
                throw new Exception("Você precisa selecionar uma pessoa responsável.");
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

        public void Dispose()
        {
            bd.Dispose();
        }
    }
}
