using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public class ReservaBus : IPortariaBus<Reserva>
    {
        private PortariaContext bd;

        public ReservaBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Reserva> Todos()
        {
            return bd.Reservas;
        }

        public void InserirOuAtualizar(Reserva entidade)
        {
            try
            {
                var r = bd.Reservas.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (r == null)
                {
                    entidade.DataHora = DateTime.Now;
                    entidade.Sessao = bd.Sessoes.Where(s => s.Id == SessaoBus.Sessao().Id).FirstOrDefault();

                    bd.Reservas.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                r.DataHora = DateTime.Now;
                r.DataHoraFim = entidade.DataHoraFim;
                r.DataHoraInicio = entidade.DataHoraInicio;
                r.Local = bd.Locais.Where(l => l.Id == entidade.Local.Id).FirstOrDefault();
                r.Pessoa = bd.Pessoas.Where(p => p.Id == entidade.Local.Id).FirstOrDefault();
                r.Sessao = bd.Sessoes.Where(s => s.Id == SessaoBus.Sessao().Id).FirstOrDefault();
                
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Reserva BuscaPorId(int id)
        {
            return bd.Reservas.Where(r => r.Id == id).FirstOrDefault();
        }

        public void Remover(Reserva entidade)
        {
            try
            {
                bd.Reservas.Remove(entidade);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
