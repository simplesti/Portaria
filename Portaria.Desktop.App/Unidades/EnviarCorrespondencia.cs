using Portaria.Business;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Unidades
{
    public partial class EnviarCorrespondencia : FormBaseWindow
    {
        private Unidade unidade = null;
        public EnviarCorrespondencia(Unidade unidade)
        {
            InitializeComponent();
            this.unidade = unidade;
            txtTituloEmail.Text = string.Format("Aviso de recebimento de correspondência - {0}", unidade.DescricaoEntidade);
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            if (CaixaMensagem.Mostrar("Deseja cancelar o envio de aviso de correspondência?", TipoCaixaMensagem.OKCancelar) == DialogResult.OK)
            {
                Close();
            }
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            var email = unidade.Locatario != null ? unidade.Locatario.Email : unidade.Proprietario.Email;

            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Não há e-mail informado para o locatário ou proprietário desta unidade!");
            }

            EnviarEmail(email);

            CaixaMensagem.Mostrar(string.Format("Aviso enviado com sucesso para {0}.", email), TipoCaixaMensagem.SomenteOK);

            Close();
        }

        private void EnviarEmail(string email)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var configuracaoBus = new ConfiguracaoBus(SessaoAtual.Sessao);

                var mail = new MailMessage(configuracaoBus.BuscarValor(Core.TipoConfiguracao.UsuarioSMTP), email);
                var client = new SmtpClient();
                client.Port = int.Parse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.PortaSMTP));
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = configuracaoBus.BuscarValor(Core.TipoConfiguracao.ServidorSMTP);
                client.EnableSsl = bool.Parse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.ConexaoSeguraSMTP));
                client.Credentials = new System.Net.NetworkCredential(configuracaoBus.BuscarValor(Core.TipoConfiguracao.UsuarioSMTP), configuracaoBus.BuscarValor(Core.TipoConfiguracao.SenhaSMTP));
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                mail.Subject = txtTituloEmail.Text;

                mail.Body = txtMensagem.Text;

                client.Send(mail);

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                CaixaMensagem.Mostrar("Erro ao enviar e-mail. Verifique as configurações de envio de e-mail.", TipoCaixaMensagem.SomenteOK);
            }

            Cursor = Cursors.Default;

        }
    }
}
