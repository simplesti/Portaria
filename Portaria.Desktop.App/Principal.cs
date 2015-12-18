using Portaria.Business;
using Portaria.Core.Model;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
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

            if (!Util.IsInDesignMode())
            {
                tabControl.Restaurar();
            }
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
            sessaoBus.FinalizarSessao(SessaoAtual.Sessao);
            SessaoAtual.Sessao = null;
        }

        private void EfetuarLogin()
        {
            var efetuarLogin = new EfetuarLogin();
            efetuarLogin.ShowDialog();

            if (SessaoAtual.Sessao == null)
            {
                Environment.Exit(0);
            }
        }
    }
}
