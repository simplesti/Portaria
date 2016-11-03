using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Data;
using Portaria.Log;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portaria.Business
{
    public class VisitanteBus : IPortariaBus<Visitante>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public VisitanteBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public VisitanteBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public Visitante BuscarPorId(int id)
        {
            return bd.Visitantes.Where(q => q.Id == id).FirstOrDefault();
        }

        public void Dispose()
        {
            bd.Dispose();
        }

        public void InserirOuAtualizar(Visitante entidade)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(entidade.Documento))
                {
                    throw new Exception("O campo documento é obrigatório.");
                }

                if (string.IsNullOrWhiteSpace(entidade.Nome))
                {
                    throw new Exception("O campo nome é obrigatório.");
                }

                if (entidade.DataHoraSaida == null || entidade.DataHoraSaida == DateTime.MinValue)
                {
                    throw new Exception("O campo Data / Hora de saída é obrigatório.");
                }

                entidade.DataHoraChegada = DateTime.Now;

                entidade.Unidade = bd.Unidades.FirstOrDefault(q => q.Id == entidade.Unidade.Id);
                entidade.Usuario = bd.Usuarios.FirstOrDefault(q => q.Id == sessao.UsuarioLogado.Id);

                bd.Visitantes.Add(entidade);

                bd.SaveChanges();

                PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(Visitante entidade)
        {
            try
            {
                var v = bd.Visitantes.FirstOrDefault(i => i.Id == entidade.Id);

                if (v != null)
                {
                    var ent = PortariaLog.SerializarEntidade(v);

                    bd.Visitantes.Remove(v);
                    bd.SaveChanges();

                    PortariaLog.Logar(v.Id, string.Empty, ent, v.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Visitante> Todos()
        {
            return bd.Visitantes;
        }

        public IEnumerable<Visitante> BuscarDoMes()
        {
            return bd.Visitantes.Where(q => q.DataHoraChegada.Month == DateTime.Now.Month);
        }
    }
}
