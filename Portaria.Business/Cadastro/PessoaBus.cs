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
    public class PessoaBus : IPortariaBus<Pessoa>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public PessoaBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public PessoaBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public IEnumerable<Pessoa> Todos()
        {
            return bd.Pessoas;
        }

        public Pessoa BuscarPorId(int id)
        {
            return bd.Pessoas.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return bd.Pessoas.Where(i => i.Nome.ToUpper().Contains(nome.ToUpper()));
        }


        public void InserirOuAtualizar(Pessoa entidade)
        {
            try
            {
                var p = bd.Pessoas.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (p == null)
                {
                    if (bd.Pessoas.Any(q => q.Nome.ToUpper() == entidade.Nome.ToUpper()))
                    {
                        throw new Exception("Pessoa já cadastrada com este nome.");
                    }

                    bd.Pessoas.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                if (bd.Pessoas.Any(q => q.Id != entidade.Id && q.Nome.ToUpper() == entidade.Nome.ToUpper()))
                {
                    throw new Exception("Pessoa já cadastrada com este nome.");
                }

                var po = bd.Pessoas.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(po);

                p.Email = entidade.Email;
                p.FoneCelular = entidade.FoneCelular;
                p.FoneComercial = entidade.FoneComercial;
                p.FoneResidencial = entidade.FoneResidencial;
                p.ControleAcessoAutorizado = entidade.ControleAcessoAutorizado;
                p.Foto = entidade.Foto;
                p.GrauParentesco = entidade.GrauParentesco;
                p.Nome = entidade.Nome;
                p.Biometria = entidade.Biometria;

                bd.SaveChanges();

                PortariaLog.Logar(p.Id, entidadeOriginal, PortariaLog.SerializarEntidade(p), p.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(Pessoa entidade)
        {
            try
            {
                var p = bd.Pessoas.FirstOrDefault(i => i.Id == entidade.Id);

                if (p != null)
                {
                    var ent = PortariaLog.SerializarEntidade(p);

                    bd.Pessoas.Remove(p);
                    bd.SaveChanges();

                    PortariaLog.Logar(p.Id, string.Empty, ent, p.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
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
