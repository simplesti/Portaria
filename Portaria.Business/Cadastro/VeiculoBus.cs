using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Portaria.Log;
using Portaria.Core.Model;
using Portaria.Core;

namespace Portaria.Business.Cadastro
{
    public class VeiculoBus : IPortariaBus<Veiculo>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public VeiculoBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public VeiculoBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public IEnumerable<Veiculo> Todos()
        {
            return bd.Veiculos;
        }

        public void InserirOuAtualizar(Veiculo entidade)
        {
            try
            {
                var v = bd.Veiculos.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (v == null)
                {
                    if (entidade.Proprietario != null)
                    {
                        entidade.Proprietario = bd.Pessoas.FirstOrDefault(q => q.Id == entidade.Proprietario.Id);
                    }

                    bd.Veiculos.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var vo = bd.Veiculos.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(vo);

                v.Cor = entidade.Cor;
                v.Foto = entidade.Foto;
                v.Nome = entidade.Nome;
                v.Placa = entidade.Placa;
                if (entidade.Proprietario != null)
                {
                    v.Proprietario = bd.Pessoas.FirstOrDefault(q => q.Id == entidade.Proprietario.Id);
                }

                bd.SaveChanges();

                PortariaLog.Logar(v.Id, entidadeOriginal, PortariaLog.SerializarEntidade(v), v.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Veiculo BuscarPorId(int id)
        {
            return bd.Veiculos.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(Veiculo entidade)
        {
            try
            {
                var v = bd.Veiculos.FirstOrDefault(i => i.Id == entidade.Id);
                if (v != null)
                {
                    var ent = PortariaLog.SerializarEntidade(v);

                    bd.Veiculos.Remove(v);
                    bd.SaveChanges();

                    PortariaLog.Logar(v.Id, string.Empty, ent, v.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
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

        public IEnumerable<Veiculo> BuscarPorUnidade(int id)
        {
            return bd.Veiculos.Include(x => x.Unidade).Where(q => q.Unidade.Id == id);
        }
    }
}
