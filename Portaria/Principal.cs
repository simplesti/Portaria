using Portaria.Business;
using Portaria.Business.Cadastro;
using Portaria.Core.Model;
using Portaria.Framework;
using Portaria.Framework.CaixaMensagem;
using Portaria.Framework.Forms;
using Portaria.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria
{
    public partial class Principal : FormBaseWindow
    {
        private List<TabPage> tabs = new List<TabPage>();

        public Principal()
        {
            InitializeComponent();

            tabs.AddRange(new[] { tabPage1, tabPage2, tabPage3, tabPage4, tabPage5, tabPage6, tabPage7, tabPage8 });

            EfetuarLogin();

            ValidaPermissoes();
        }

        private void ValidaPermissoes()
        {
            foreach (TabPage tabPage in tabs)
            {
                if (!((IPortariaTab)tabPage.Controls[0]).TiposUsuariosPermitidos.Contains(SessaoBus.Sessao().UsuarioLogado.Tipo))
                {
                    tabControl.Controls.Remove(tabPage);
                }
            }
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

        private void CarregarTab()
        {
            var portariaTab = tabControl.SelectedTab.Controls[0] as PortariaTabBase;
            if (portariaTab != null)
            {
                portariaTab.Carregar();
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTab();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CarregarTab();
        }

    }
}
