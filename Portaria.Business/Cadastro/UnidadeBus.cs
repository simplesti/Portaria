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

namespace Portaria.Business.Cadastro
{
    public class UnidadeBus : IPortariaBus<Unidade>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public UnidadeBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public UnidadeBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public IEnumerable<Unidade> Todos(bool somente30)
        {
            var query = bd.Unidades.AsQueryable();

            if (somente30)
            {
                query = query.Take(30);
            }

            return query.OrderBy(u => u.Numero);
        }

        public IEnumerable<Unidade> Todos()
        {
            return bd.Unidades.OrderBy(u => u.Numero);
        }

        public Unidade BuscarPorNumeroBloco(int numero, string bloco)
        {
            return bd.Unidades.Where(i => i.Numero == numero && i.Bloco.Nome == bloco)
                .FirstOrDefault();
        }

        public IEnumerable<Unidade> BuscarPorNumero(int numero, bool somente30)
        {
            var query = bd.Unidades.Where(i => i.Numero == numero).AsQueryable();
            if (somente30)
            {
                query = query.Take(30);
            }

            return query.OrderBy(u => u.Numero);
        }

        public IEnumerable<Unidade> BuscarPorBloco(string bloco)
        {
            return bd.Unidades.Where(i => i.Bloco.Nome == bloco).OrderBy(u => u.Numero);
        }

        public void InserirOuAtualizar(Unidade entidade)
        {
            try
            {
                var u = bd.Unidades.Where(i => i.Id == entidade.Id).FirstOrDefault();
                var blocoBus = new BlocoBus(this.sessao, this.bd);

                if (u == null)
                {
                    if (bd.Unidades.Any(q => q.Numero == entidade.Numero && q.Bloco.Id == entidade.Bloco.Id))
                    {
                        throw new Exception("Unidade já cadastrada com este número neste bloco.");
                    }

                    entidade.DataAtualizacao = DateTime.Now;
                    entidade.Bloco = blocoBus.BuscarPorId(entidade.Bloco.Id);
                    bd.Unidades.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                if (bd.Unidades.Any(q => q.Id != entidade.Id && (q.Numero == entidade.Numero && q.Bloco.Id == entidade.Bloco.Id)))
                {
                    throw new Exception("Unidade já cadastrada com este número neste bloco.");
                }

                var uo = bd.Unidades.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(uo);

                u.DataAtualizacao = DateTime.Now;
                u.AparelhosGas = entidade.AparelhosGas;
                u.Bloco = blocoBus.BuscarPorId(entidade.Bloco.Id);
                u.Numero = entidade.Numero;
                u.Inadimplente = entidade.Inadimplente;

                var pessoaBus = new PessoaBus(this.sessao, this.bd);

                if (entidade.Proprietario != null)
                {
                    u.Proprietario = pessoaBus.BuscarPorId(entidade.Proprietario.Id);
                }
                if (entidade.Locatario != null)
                {
                    u.Locatario = pessoaBus.BuscarPorId(entidade.Locatario.Id);
                }
                if (entidade.Conjuge != null)
                {
                    u.Conjuge = pessoaBus.BuscarPorId(entidade.Conjuge.Id);
                }

                if (entidade.Veiculos != null)
                {
                    var veiculos = new List<Veiculo>();
                    foreach(var veiculo in entidade.Veiculos)
                    {
                        veiculos.Add(bd.Veiculos.FirstOrDefault(q => q.Id == veiculo.Id));
                    }
                    entidade.Veiculos.Clear();
                    entidade.Veiculos = veiculos;
                }

                u.Observacoes = entidade.Observacoes;

                bd.SaveChanges();

                PortariaLog.Logar(u.Id, entidadeOriginal, PortariaLog.SerializarEntidade(u), u.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Unidade BuscarPorId(int id)
        {
            return bd.Unidades.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Unidade> BuscarPorIds(IEnumerable<int> ids, bool somente30)
        {
            var query = bd.Unidades.Where(e => ids.Contains(e.Id)).AsQueryable();
            if (somente30)
            {
                query = query.Take(30);
            }
            return query;
        }

        public IEnumerable<Unidade> BuscarPorPessoa(string nome, bool somente30)
        {
            var n = nome.ToUpper().Split(' ');
            var retorno = new List<Unidade>();

            foreach (var termo in n)
            {
                var query = bd.Unidades.Where(q => q.Autorizados.Any(x => x.Nome.ToUpper().Contains(termo)) ||
                                          q.Conjuge.Nome.ToUpper().Contains(termo) ||
                                          q.Funcionarios.Any(x => x.Nome.ToUpper().Contains(termo)) ||
                                          q.Locatario.Nome.ToUpper().Contains(termo) ||
                                          q.Proprietario.Nome.ToUpper().Contains(termo));
                retorno.AddRange(query.ToList());
            }

            retorno = retorno.Distinct().ToList();

            if (somente30)
            {
                retorno = retorno.Take(30).ToList();
            }

            return retorno;
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

                    PortariaLog.Logar(u.Id, string.Empty, ent, u.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
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

        public IEnumerable<Pessoa> BuscarAutorizados(int id)
        {
            return bd.Unidades.FirstOrDefault(q => q.Id == id).Autorizados;
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

        public void Dispose()
        {
            bd.Dispose();
        }

        public IEnumerable<Funcionario> BuscarFuncionarios(int id)
        {
            return bd.Unidades.FirstOrDefault(q => q.Id == id).Funcionarios;
        }
    }
}
