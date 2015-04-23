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
    public class UnidadeBus : IPortariaBus<Unidade>
    {
        private PortariaContext bd;

        public UnidadeBus()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<Unidade> Todos()
        {
            return bd.Unidades.OrderBy(u => u.Numero);
        }

        public Unidade Buscar(int numero, string bloco)
        {
            return bd.Unidades.Where(i => i.Numero == numero && i.Bloco.Nome == bloco)
                .FirstOrDefault();
        }

        public IEnumerable<Unidade> BuscarPorNumero(int numero)
        {
            return bd.Unidades.Where(i => i.Numero == numero).OrderBy(u => u.Numero);
        }

        public IEnumerable<Unidade> BuscarPorBloco(string bloco)
        {
            return bd.Unidades.Where(i => i.Bloco.Nome == bloco).OrderBy(u => u.Numero);
        }

        public void InserirOuAtualizar(Unidade entidade)
        {
            try
            {
                var u = bd.Unidades.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var blocoBus = new BlocoBus();

                if (u == null)
                {
                    if (bd.Unidades.Any(q => q.Numero == entidade.Numero && q.Bloco.Id == entidade.Bloco.Id))
                    {
                        throw new Exception("Unidade já cadastrada com este número neste bloco.");
                    }

                    entidade.DataAtualizacao = DateTime.Now;
                    entidade.Bloco = blocoBus.BuscaPorId(entidade.Bloco.Id);
                    bd.Unidades.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                if (bd.Unidades.Any(q => q.Id != entidade.Id && (q.Numero == entidade.Numero && q.Bloco.Id == entidade.Bloco.Id)))
                {
                    throw new Exception("Unidade já cadastrada com este número neste bloco.");
                }

                var entidadeOriginal = PortariaLog.SerializarEntidade(u);

                u.DataAtualizacao = DateTime.Now;
                u.AparelhosGas = entidade.AparelhosGas;
                u.Bloco = blocoBus.BuscaPorId(entidade.Bloco.Id);
                u.Numero = entidade.Numero;
                u.Inadimplente = entidade.Inadimplente;

                var pessoaBus = new PessoaBus();

                if (entidade.Proprietario != null)
                {
                    u.Proprietario = pessoaBus.BuscaPorId(entidade.Proprietario.Id);
                }
                if (entidade.Locatario != null)
                {
                    u.Locatario = pessoaBus.BuscaPorId(entidade.Locatario.Id);
                }
                if (entidade.Conjuge != null)
                {
                    u.Conjuge = pessoaBus.BuscaPorId(entidade.Conjuge.Id);
                }

                u.Observacoes = entidade.Observacoes;

                bd.SaveChanges();

                PortariaLog.Logar(u.Id, entidadeOriginal, PortariaLog.SerializarEntidade(u), u.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Unidade BuscaPorId(int id)
        {
            return bd.Unidades.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(Unidade entidade)
        {
            try
            {
                var u = bd.Unidades.FirstOrDefault(i => i.Id == entidade.Id);
                if (u != null)
                {
                    var ent = PortariaLog.SerializarEntidade(u);

                    bd.Unidades.Remove(u);
                    bd.SaveChanges();

                    PortariaLog.Logar(u.Id, string.Empty, ent, u.TipoEntidade, SessaoBus.Sessao().Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverAutorizado(Pessoa pessoa, Unidade Unidade)
        {
            try
            {
                Unidade = bd.Unidades.FirstOrDefault(u => u.Id == Unidade.Id);
                pessoa = bd.Pessoas.FirstOrDefault(p => p.Id == pessoa.Id);

                if (!Unidade.Autorizados.Contains(pessoa))
                {
                    throw new Exception(string.Format("{0} não está na lista de autorizados da unidade {1}", pessoa.Nome, Unidade.Numero.ToString()));
                }

                Unidade.Autorizados.Remove(pessoa);

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AdicionarAutorizado(Pessoa pessoa, Unidade Unidade)
        {
            try
            {
                Unidade = bd.Unidades.FirstOrDefault(u => u.Id == Unidade.Id);
                pessoa = bd.Pessoas.FirstOrDefault(p => p.Id == pessoa.Id);

                if (Unidade.Autorizados == null)
                {
                    Unidade.Autorizados = new List<Pessoa>();
                }

                Unidade.Autorizados.Add(pessoa);

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
