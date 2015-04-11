using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Portaria.Log;

namespace Portaria.Business.Cadastro
{
    public class VeiculoBus : IPortariaBus<Veiculo>
    {
        private PortariaContext bd;

        public VeiculoBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Veiculo> Todos()
        {
            return bd.Veiculos;
        }

        public void InserirOuAtualizar(Veiculo entidade)
        {
            try
            {
                var v = bd.Veiculos.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (v == null)
                {
                    bd.Veiculos.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var entidadeOriginal = PortariaLog.SerializarEntidade(v);

                v.Cor = entidade.Cor;
                v.Foto = entidade.Foto;
                v.Nome = entidade.Nome;
                v.Placa = entidade.Placa;

                bd.SaveChanges();

                PortariaLog.Logar(v.Id, entidadeOriginal, PortariaLog.SerializarEntidade(v), v.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Veiculo BuscaPorId(int id)
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
                    bd.Veiculos.Remove(v);
                    bd.SaveChanges();

                    PortariaLog.Logar(v.Id, string.Empty, PortariaLog.SerializarEntidade(v), v.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
