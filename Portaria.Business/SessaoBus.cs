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
    public class SessaoBus : IPortariaBus<Sessao>
    {
        private PortariaContext bd;

        public SessaoBus()
        {
            bd = new PortariaContext();
        }

        public SessaoBus(PortariaContext bd)
        {
            this.bd = bd;
        }

        public IEnumerable<Sessao> Todos()
        {
            return bd.Sessoes;
        }

        public void InserirOuAtualizar(Sessao entidade)
        {
            try
            {
                var s = bd.Sessoes.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (s == null)
                {
                    bd.Sessoes.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                s.DataHoraInicio = entidade.DataHoraInicio;
                s.DataHoraFim = entidade.DataHoraFim;
                s.NomeEstacao = entidade.NomeEstacao;
                s.UsuarioLogado = entidade.UsuarioLogado;

                bd.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sessao BuscarPorId(int id)
        {
            return bd.Sessoes.Include(q => q.UsuarioLogado).FirstOrDefault(i => i.Id == id);
        }

        public void Remover(Sessao entidade)
        {
            try
            {
                var s = bd.Sessoes.FirstOrDefault(i => i.Id == entidade.Id);

                if (s != null)
                {
                    bd.Sessoes.Remove(s);
                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sessao InicializarSessao(Usuario usuario)
        {
            try
            {
                var sessao = new Sessao();
                sessao.DataHoraInicio = DateTime.Now;
                sessao.NomeEstacao = Environment.MachineName;
                sessao.UsuarioLogado = usuario;

                InserirOuAtualizar(sessao);

                return sessao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FinalizarSessao(Sessao sessao)
        {
            try
            {
                if (sessao == null)
                {
                    throw new Exception("Não existe sessão aberta.");
                }

                var s = BuscarPorId(sessao.Id);
                s.DataHoraFim = DateTime.Now;
                bd.SaveChanges();
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
