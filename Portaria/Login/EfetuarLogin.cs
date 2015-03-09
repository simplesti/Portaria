using Portaria.Business;
using Portaria.Business.Cadastro;
using Portaria.Framework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Login
{
    public partial class EfetuarLogin : FormBaseWindow
    {
        public EfetuarLogin()
        {
            InitializeComponent();
            Aquecer();
            ConfiguracoesUsuarioVisivel = false;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            ProcessarLogin();
        }

        private void Aquecer()
        {
            var unidadeBus = new UnidadeBus();

            var dumy = unidadeBus.Todos().FirstOrDefault();

        }

        private void ProcessarLogin()
        {
            var usuarioBus = new UsuarioBus();
            
            usuarioBus.EfetuarLogin(txtUsuario.Text, txtSenha.Text);

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
