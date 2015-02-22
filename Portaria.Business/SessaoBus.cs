using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public class SessaoBus : IPortariaBus<Sessao>
    {
        private PortariaContext bd;

        private static Sessao sessaoAtual = null;

        public static Sessao Sessao()
        {
            return sessaoAtual;
        }

        public SessaoBus()
        {
            bd = PortariaContext.BD;
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

        public Sessao BuscaPorId(int id)
        {
            return bd.Sessoes.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(Sessao entidade)
        {
            try
            {
                var s = bd.Sessoes.FirstOrDefault(i => i.Id == entidade.Id);

                if(s != null)
                {
                    bd.Sessoes.Remove(s);
                    bd.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InicializarSessao(Usuario usuario)
        {
            try
            {
                var sessao = new Sessao();
                sessao.DataHoraInicio = DateTime.Now;
                sessao.NomeEstacao = Environment.MachineName;
                sessao.UsuarioLogado = usuario;

                InserirOuAtualizar(sessao);

                sessaoAtual = sessao;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void FinalizarSessao()
        {
            try
            {
                if (sessaoAtual == null)
                {
                    throw new Exception("Não existe sessão aberta.");
                }

                var sessao = BuscaPorId(sessaoAtual.Id);
                sessao.DataHoraFim = DateTime.Now;
                bd.SaveChanges();

                sessaoAtual = null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
