using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Portaria.Log;

namespace Portaria.Business
{
    public class UsuarioBus : IPortariaBus<Usuario>
    {
        private string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private PortariaContext bd;
        private Sessao sessao;

        public UsuarioBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public UsuarioBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public IEnumerable<Usuario> Todos()
        {
            return bd.Usuarios;
        }

        public void InserirOuAtualizar(Usuario entidade)
        {
            try
            {
                var u = bd.Usuarios.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (u == null)
                {
                    if (bd.Usuarios.Any( q => q.Nome.ToUpper() == entidade.Nome.ToUpper() || q.Login.ToUpper() == entidade.Login.ToUpper()))
                    {
                        throw new Exception("Usuário já cadastrado com este nome ou login.");
                    }

                    entidade.Senha = getMD5Hash(entidade.Senha);
                    bd.Usuarios.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                if (bd.Usuarios.Any(q => q.Id != entidade.Id &&( q.Nome.ToUpper() == entidade.Nome.ToUpper() || q.Login.ToUpper() == entidade.Login.ToUpper())))
                {
                    throw new Exception("Usuário já cadastrado com este nome ou login.");
                }

                var entidadeOriginal = PortariaLog.SerializarEntidade(u);

                u.Login = entidade.Login;
                u.Biometria = entidade.Biometria;
                u.CPF = entidade.CPF;
                u.RG = entidade.RG;
                u.Nome = entidade.Nome;
                if (u.Senha != entidade.Senha)
                {
                    u.Senha = getMD5Hash(entidade.Senha);
                }
                u.Tipo = entidade.Tipo;
                u.CorTema = entidade.CorTema;
                u.PosicaoAbas = entidade.PosicaoAbas;

                bd.SaveChanges();

                PortariaLog.Logar(u.Id, entidadeOriginal, PortariaLog.SerializarEntidade(u), u.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario BuscaPorId(int id)
        {
            return bd.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Remover(Usuario entidade)
        {
            try
            {
                var u = bd.Usuarios.FirstOrDefault(i => i.Id == entidade.Id);

                if (u != null)
                {
                    var ent = PortariaLog.SerializarEntidade(u);

                    bd.Usuarios.Remove(u);
                    bd.SaveChanges();

                    PortariaLog.Logar(u.Id, string.Empty, ent, u.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sessao EfetuarLogin(string usuario, string senha)
        {
            try
            {
                var u = bd.Usuarios.Where(i => i.Login == usuario).FirstOrDefault();

                if (u == null)
                {
                    throw new Exception("Usuário não encontrado.");
                }

                if (u.Senha != getMD5Hash(senha))
                {
                    throw new Exception("Senha incorreta.");
                }

                var sessaoBus = new SessaoBus(this.bd);
                return sessaoBus.InicializarSessao(u);
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
