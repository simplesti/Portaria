using Portaria.Core.Model;
using Portaria.Data;
using Portaria.Log;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Portaria.Business
{
    public class CategoriaLivroNegroBus : IPortariaBus<CategoriaLivroNegro>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public CategoriaLivroNegroBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public CategoriaLivroNegroBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public CategoriaLivroNegro BuscarPorId(int id)
        {
            return bd.CategoriasLivroNegro.Where(q => q.Id == id).FirstOrDefault();
        }

        public void Dispose()
        {
            bd.Dispose();
        }

        public void InserirOuAtualizar(CategoriaLivroNegro entidade)
        {
            try
            {
                var c = bd.CategoriasLivroNegro.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (c == null)
                {
                    if (bd.CategoriasLivroNegro.Any(q => q.Nome.ToUpper() == entidade.Nome.ToUpper() ))
                    {
                        throw new Exception("Categoria já cadastrada com este nome.");
                    }
                    
                    bd.CategoriasLivroNegro.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                if (bd.CategoriasLivroNegro.Any(q => q.Id != entidade.Id && (q.Nome.ToUpper() == entidade.Nome.ToUpper() )))
                {
                    throw new Exception("Categoria já cadastrada com este nome.");
                }

                var co = bd.CategoriasLivroNegro.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(co);
                
                c.Nome = entidade.Nome;
                c.EnviarEmailNotificacao = entidade.EnviarEmailNotificacao;

                bd.SaveChanges();

                PortariaLog.Logar(c.Id, entidadeOriginal, PortariaLog.SerializarEntidade(c), c.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remover(CategoriaLivroNegro entidade)
        {
            try
            {
                var c = bd.CategoriasLivroNegro.FirstOrDefault(i => i.Id == entidade.Id);

                if (c != null)
                {
                    var ent = PortariaLog.SerializarEntidade(c);

                    bd.CategoriasLivroNegro.Remove(c);
                    bd.SaveChanges();

                    PortariaLog.Logar(c.Id, string.Empty, ent, c.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<CategoriaLivroNegro> Todos()
        {
            return bd.CategoriasLivroNegro;
        }
    }
}
