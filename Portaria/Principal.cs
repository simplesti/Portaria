using Portaria.Business;
using Portaria.Framework.CaixaMensagem;
using Portaria.Framework.Forms;
using Portaria.Login;
using System;
using System.Windows.Forms;

namespace Portaria
{
    public partial class Principal : FormBaseWindow
    {
        public Principal()
        {
            InitializeComponent();

            EfetuarLogin();

            tabControl.Restaurar();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CaixaMensagem.Mostrar("Deseja efetuar logoff e sair do Portaria Digital?", TipoCaixaMensagem.OKCancelar) == DialogResult.OK)
            {
                EfetuarLogoff();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void EfetuarLogoff()
        {
            var sessaoBus = new SessaoBus();
            sessaoBus.FinalizarSessao();
        }

        private void EfetuarLogin()
        {
            var efetuarLogin = new EfetuarLogin();
            efetuarLogin.ShowDialog();

            if (SessaoBus.Sessao() == null)
            {
                Environment.Exit(0);
            }
        }
    }
}
