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
    public class FuncionarioBus : IPortariaBus<Funcionario>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public FuncionarioBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public FuncionarioBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public IEnumerable<Funcionario> Todos()
        {
            return bd.Funcionarios;
        }

        public void InserirOuAtualizar(Funcionario entidade)
        {
            try
            {
                var f = bd.Funcionarios.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (f == null)
                {
                    bd.Funcionarios.Add(entidade);
                    bd.SaveChanges();
                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var fo = bd.Funcionarios.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(fo);

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

                PortariaLog.Logar(f.Id, entidadeOriginal, PortariaLog.SerializarEntidade(f), f.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario BuscarPorId(int id)
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

                    PortariaLog.Logar(f.Id, string.Empty, ent, f.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
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
    }
}
