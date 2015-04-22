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
    public class FuncionarioBus : IPortariaBus<Funcionario>
    {
        private PortariaContext bd;

        public FuncionarioBus()
        {
            bd = PortariaContext.BD;
        }
        public IEnumerable<Funcionario> Todos()
        {
            return bd.Funcionarios;
        }

        public void InserirOuAtualizar(Funcionario entidade)
        {
            try
            {
                var f = bd.Funcionarios.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (f == null)
                {
                    bd.Funcionarios.Add(entidade);
                    bd.SaveChanges();
                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var entidadeOriginal = PortariaLog.SerializarEntidade(f);

                f.AutorizadaSemPresenca = entidade.AutorizadaSemPresenca;
                f.Descricao = entidade.Descricao;
                f.Fone = entidade.Fone;
                f.Documento = entidade.Documento;
                f.Foto = entidade.Foto;
                f.Frequencia = entidade.Frequencia;
                f.Nome = entidade.Nome;
                f.HorarioEntrada = entidade.HorarioEntrada;
                f.HorarioSaida = entidade.HorarioSaida;
                f.Biometria = entidade.Biometria;

                bd.SaveChanges();

                PortariaLog.Logar(f.Id, entidadeOriginal, PortariaLog.SerializarEntidade(f), f.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario BuscaPorId(int id)
        {
            return bd.Funcionarios.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(Funcionario entidade)
        {
            try
            {
                var f = bd.Funcionarios.FirstOrDefault(i => i.Id == entidade.Id);

                if (f != null)
                {
                    var ent = PortariaLog.SerializarEntidade(f);

                    bd.Funcionarios.Remove(f);
                    bd.SaveChanges();

                    PortariaLog.Logar(f.Id, string.Empty, ent, f.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
