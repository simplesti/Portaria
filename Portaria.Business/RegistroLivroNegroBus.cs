using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Net.Mail;

namespace Portaria.Business
{
    public class RegistroLivroNegroBus : IPortariaBus<RegistroLivroNegro>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public RegistroLivroNegroBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        RegistroLivroNegroBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }
        public IEnumerable<RegistroLivroNegro> Todos()
        {
            return bd.RegistrosLivroNegro;
        }

        public void InserirOuAtualizar(RegistroLivroNegro entidade)
        {
            try
            {
                ValidarRegistro(entidade);

                var r = bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == entidade.Id);

                if (r == null)
                {
                    entidade.Data = DateTime.Now;
                    entidade.Sessao = bd.Sessoes.FirstOrDefault(i => i.Id == sessao.Id);
                    entidade.Pessoa = bd.Pessoas.FirstOrDefault(p => p.Id == entidade.Pessoa.Id);
                    entidade.Categoria = bd.CategoriasLivroNegro.FirstOrDefault(c => c.Id == entidade.Categoria.Id);
                    bd.RegistrosLivroNegro.Add(entidade);

                    bd.SaveChanges();

                    if (entidade.Categoria.EnviarEmailNotificacao)
                    {
                        var envio = new Task(() => { EnviarEmailNotificacao(entidade); });
                        envio.Start();
                    }

                    return;
                }

                r.Data = DateTime.Now;
                r.Pessoa = bd.Pessoas.FirstOrDefault(p => p.Id == entidade.Pessoa.Id);
                r.Sessao = bd.Sessoes.FirstOrDefault(i => i.Id == sessao.Id);
                r.Mensagem = entidade.Mensagem;
                r.Categoria = bd.CategoriasLivroNegro.FirstOrDefault(c => c.Id == entidade.Id);

                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void EnviarEmailNotificacao(RegistroLivroNegro registro)
        {
            try
            {
                var configuracaoBus = new ConfiguracaoBus(sessao, bd);

                var mail = new MailMessage(configuracaoBus.BuscarValor(Core.TipoConfiguracao.UsuarioSMTP), configuracaoBus.BuscarValor(Core.TipoConfiguracao.EmailResponsavel));
                var client = new SmtpClient();
                client.Port = int.Parse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.PortaSMTP));
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = configuracaoBus.BuscarValor(Core.TipoConfiguracao.ServidorSMTP);
                client.EnableSsl = bool.Parse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.ConexaoSeguraSMTP));
                client.Credentials = new System.Net.NetworkCredential(configuracaoBus.BuscarValor(Core.TipoConfiguracao.UsuarioSMTP), configuracaoBus.BuscarValor(Core.TipoConfiguracao.SenhaSMTP));
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                mail.Subject = configuracaoBus.BuscarValor(Core.TipoConfiguracao.TituloEMail);

                var msg = new StringBuilder();
                msg.AppendLine("Notificação de registro novo no livro negro");
                msg.AppendLine();
                msg.AppendLine("Data do registro: " + registro.Data.ToString("dd/MM/yyyy HH:mm:ss"));
                msg.AppendLine("Categoria: " + registro.Categoria.Nome);
                msg.AppendLine("Reclamante: " + registro.Pessoa.Nome);
                msg.AppendLine("Usuário recebedor: " + registro.Sessao.UsuarioLogado.Nome);
                msg.AppendLine("Entidades envolvidas:");


                var entidadeHelper = new EntidadeHelper();
                var entidades = entidadeHelper.BuscarEntidades(registro.Entidades).ToList();

                foreach (var entidade in entidades)
                {
                    msg.AppendLine(entidade.DescricaoEntidade);
                }

                msg.AppendLine();
                msg.AppendLine("Mensagem:");
                msg.AppendLine(registro.Mensagem);

                mail.Body = msg.ToString();

                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar e-mail de notificação ao responsável. Verifique as configurações do servidor de e-mail.");
            }
        }

        private void ValidarRegistro(RegistroLivroNegro entidade)
        {
            if (entidade.Pessoa == null)
            {
                throw new Exception("Você precisa selecionar uma pessoa responsável.");
            }

            if (entidade.Categoria == null)
            {
                throw new Exception("Você precisa selecionar uma categoria para a reclamação.");
            }
        }

        public RegistroLivroNegro BuscarPorId(int id)
        {
            return bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == id);
        }

        public void Remover(RegistroLivroNegro entidade)
        {
            try
            {
                var r = bd.RegistrosLivroNegro.FirstOrDefault(i => i.Id == entidade.Id);

                if (r != null)
                {
                    bd.RegistrosLivroNegro.Remove(r);
                    bd.SaveChanges();
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
