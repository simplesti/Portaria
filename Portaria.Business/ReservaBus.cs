using Portaria.Core.Model;
using Portaria.Data;
using Portaria.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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
                ValidarReserva(entidade);

                var r = bd.Reservas.Where(i => i.Id == entidade.Id).FirstOrDefault();
                var sessao = SessaoBus.Sessao();

                if (r == null)
                {
                    entidade.DataHora = DateTime.Now;
                    entidade.Sessao = bd.Sessoes.Where(s => s.Id == sessao.Id).FirstOrDefault();
                    entidade.Local = bd.Locais.Where(l => l.Id == entidade.Local.Id).FirstOrDefault();
                    entidade.Pessoa = bd.Pessoas.Where(p => p.Id == entidade.Pessoa.Id).FirstOrDefault();

                    bd.Reservas.Add(entidade);
                    bd.SaveChanges();
                    return;
                }

                r.DataHora = DateTime.Now;
                r.DataHoraFim = entidade.DataHoraFim;
                r.DataHoraInicio = entidade.DataHoraInicio;
                r.Local = bd.Locais.Where(l => l.Id == entidade.Local.Id).FirstOrDefault();
                r.Pessoa = bd.Pessoas.Where(p => p.Id == entidade.Pessoa.Id).FirstOrDefault();
                r.Sessao = bd.Sessoes.Where(s => s.Id == sessao.Id).FirstOrDefault();

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ValidarReserva(Reserva reserva)
        {
            if (reserva.Pessoa == null)
            {
                throw new Exception("Você precisa selecionar uma pessoa para efetuar a reserva.");
            }

            if (reserva.Pessoa.Inadimplente)
            {
                throw new Exception("Esta pessoa não está autorizada a efetuar reservas.");
            }

            if (reserva.DataHoraFim == null || reserva.DataHoraInicio == null)
            {
                throw new Exception("Você precisa informar a data início e fim da reserva.");
            }

            if (reserva.DataHoraInicio >= reserva.DataHoraFim)
            {
                throw new Exception("A data do fim da reserva deve ser posterior a data de início.");
            }

            var reservasLocal = bd.Reservas.Where(r => r.Local.Id == reserva.Local.Id);

            foreach (var item in reservasLocal)
            {
                if (reserva.DataHoraInicio.Between(item.DataHoraInicio, item.DataHoraFim)
                    || reserva.DataHoraFim.Between(item.DataHoraInicio, item.DataHoraFim))
                {
                    throw new Exception(string.Format("Este local já está reservado para {0} entre {1} e {2}.",
                        item.Pessoa.Nome, item.DataHoraInicio.ToString("dd/MM/yyyy HH:mm"), item.DataHoraFim.ToString("dd/MM/yyyy HH:mm")));
                }
            }
        }

        public Reserva BuscaPorId(int id)
        {
            return bd.Reservas.FirstOrDefault(r => r.Id == id);
        }

        public void Remover(Reserva entidade)
        {
            try
            {
                var r = bd.Reservas.FirstOrDefault(i => i.Id == entidade.Id);

                if (r != null)
                {
                    bd.Reservas.Remove(r);
                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
