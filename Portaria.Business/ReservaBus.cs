using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Portaria.Log;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Business.Cadastro;

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

                var r = bd.Reservas.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var sessao = SessaoBus.Sessao();

                if (r == null)
                {
                    entidade.DataHora = DateTime.Now;
                    entidade.Sessao = bd.Sessoes.Where(s => s.Id == sessao.Id).FirstOrDefault();
                    entidade.Local = bd.Locais.Where(l => l.Id == entidade.Local.Id).FirstOrDefault();
                    entidade.Pessoa = bd.Pessoas.Where(p => p.Id == entidade.Pessoa.Id).FirstOrDefault();
                    entidade.Unidade = bd.Unidades.Where(q => q.Id == entidade.Unidade.Id).FirstOrDefault();

                    bd.Reservas.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var entidadeOriginal = PortariaLog.SerializarEntidade(r);

                r.DataHora = DateTime.Now;
                r.DataHoraFim = entidade.DataHoraFim;
                r.DataHoraInicio = entidade.DataHoraInicio;
                r.Local = bd.Locais.Where(l => l.Id == entidade.Local.Id).FirstOrDefault();
                r.Pessoa = bd.Pessoas.Where(p => p.Id == entidade.Pessoa.Id).FirstOrDefault();
                r.Sessao = bd.Sessoes.Where(s => s.Id == sessao.Id).FirstOrDefault();
                r.Unidade = bd.Unidades.Where(q => q.Id == entidade.Unidade.Id).FirstOrDefault();

                bd.SaveChanges();

                PortariaLog.Logar(r.Id, entidadeOriginal, PortariaLog.SerializarEntidade(r), r.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Alterar);
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

            if (reserva.Unidade == null)
            {
                throw new Exception("Você precisa selecionar uma unidade para efetuar a reserva.");
            }

            if (reserva.Unidade.Inadimplente)
            {
                throw new Exception("Esta unidade não está autorizada a efetuar reservas.");
            }
            
            if (reserva.DataHoraFim == null || reserva.DataHoraInicio == null || reserva.DataHoraFim == DateTime.MinValue || reserva.DataHoraInicio == DateTime.MinValue)
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
                    var ent = PortariaLog.SerializarEntidade(r);

                    bd.Reservas.Remove(r);
                    bd.SaveChanges();

                    PortariaLog.Logar(r.Id, string.Empty, ent, r.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
