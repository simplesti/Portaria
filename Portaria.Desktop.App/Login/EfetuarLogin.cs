using Portaria.Business;
using Portaria.Desktop.Framework.Forms;
using Portaria.Desktop.Framework.Plugin;
using System;
using System.Windows.Forms;

namespace Portaria.Login
{
    public partial class EfetuarLogin : MaterialPortariaFormWindow
    {
        public EfetuarLogin()
        {
            InitializeComponent();
            BusUtils.Aquecer();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            ProcessarLogin();
        }

        private void ProcessarLogin()
        {
            var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);

            SessaoAtual.Sessao = usuarioBus.EfetuarLogin(txtUsuario.Text, txtSenha.Text);

            GerenciadorPlugins.LoginRealizado(txtUsuario.Text, new EventArgs());

            Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
                e.Handled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                ProcessarLogin();
                e.Handled = true;
            }
        }
    }
}
