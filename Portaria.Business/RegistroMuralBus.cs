using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Data;
using Portaria.Log;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portaria.Business
{
    public class RegistroMuralBus : IPortariaBus<RegistroMural>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public RegistroMuralBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public RegistroMuralBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public RegistroMural BuscarPorId(int id)
        {
            return bd.RegistrosMural.Where(q => q.Id == id).FirstOrDefault();
        }

        public void Dispose()
        {
            bd.Dispose();
        }

        public void InserirOuAtualizar(RegistroMural entidade)
        {
            try
            {
                if (string.IsNullOrEmpty(entidade.Mensagem))
                {
                    throw new Exception("Você deve preencher a mensagem para inserir no mural.");
                }

                entidade.DataHora = DateTime.Now;
                entidade.Usuario = bd.Usuarios.FirstOrDefault(u => u.Id == sessao.UsuarioLogado.Id);

                bd.RegistrosMural.Add(entidade);
                bd.SaveChanges();

                PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(RegistroMural entidade)
        {
            try
            {
                var r = bd.RegistrosMural.FirstOrDefault(i => i.Id == entidade.Id);

                if (r != null)
                {
                    var ent = PortariaLog.SerializarEntidade(r);

                    bd.RegistrosMural.Remove(r);
                    bd.SaveChanges();

                    PortariaLog.Logar(r.Id, string.Empty, ent, r.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<RegistroMural> Todos()
        {
            return bd.RegistrosMural;
        }

        public IEnumerable<RegistroMural> Recentes(int limite)
        {
            return bd.RegistrosMural.Take(limite).OrderByDescending(o => o.DataHora).ToList();
        }
    }
}
