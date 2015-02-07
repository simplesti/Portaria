using Portaria.Business;
using Portaria.Business.Cadastro;
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
    public partial class Principal : FormWindowTabbed
    {
        public Principal()
        {
            InitializeComponent();

            EfetuarLogin();

            ValidaPermissoes();
        }

        private void ValidaPermissoes()
        {
            foreach(Control tab in tabControl.Controls)
            {
                var portariaTab = tab.Controls[0] as IPortariaTab;
                if (portariaTab != null)
                {
                    if (!portariaTab.TiposUsuariosPermitidos.Contains(SessaoBus.Sessao().UsuarioLogado.Tipo))
                    {
                        tabControl.Controls.Remove(tab);
                    }
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
            if (CaixaMensagem.Mostrar("Deseja efetuar logoff e sair do Portaria Digital?",TipoCaixaMensagem.OKCancelar) == DialogResult.OK)
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
    }
}
