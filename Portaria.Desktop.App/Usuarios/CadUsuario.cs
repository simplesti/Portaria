using Portaria.Biometria;
using Portaria.Business;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Portaria.Usuarios
{
    public partial class CadUsuario : FormBaseWindow
    {
        private Usuario usuario;

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
                bsUsuario.DataSource = usuario;
                
                if (usuario.Biometria != null)
                {
                    lblStatusBiometria.Text = "BIOMETRIA CAPTURADA";
                    lblStatusBiometria.ForeColor = Color.DarkGreen;
                    botaoVerificarBiometria.Enabled = true;
                }
                else
                {
                    lblStatusBiometria.Text = "BIOMETRIA NÃO CAPTURADA";
                    lblStatusBiometria.ForeColor = Color.DarkRed;
                    botaoVerificarBiometria.Enabled = false;
                }
            }
        }

        public CadUsuario()
        {
            InitializeComponent();
            PopulaComboTipo();
            Usuario = new Usuario() { Tipo = TipoUsuario.Administrador, CorTema = -1, ControleAcessoAutorizado = true };
        }

        public CadUsuario(Usuario usuario)
        {
            InitializeComponent();
            PopulaComboTipo();
            Usuario = usuario;
        }

        private void PopulaComboTipo()
        {
            cboTipo.DataSource = new List<TipoUsuario>() { TipoUsuario.Administrador, TipoUsuario.SomenteLeitura };
        }

        private void botaoCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, System.EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);
            usuarioBus.InserirOuAtualizar(Usuario);

            Close();
        }

        private void CapturarBiometria()
        {
            var biometria = PortariaBiometriaCapturar.Capturar();
            if (biometria != null)
            {
                Usuario.Biometria = biometria;

                lblStatusBiometria.Text = "BIOMETRIA CAPTURADA";
                lblStatusBiometria.ForeColor = Color.DarkGreen;

                botaoVerificarBiometria.Enabled = true;
            }
        }

        private void botaoCapturarBiometria_Click(object sender, EventArgs e)
        {
            CapturarBiometria();
        }

        private void botaoVerificarBiometria_Click(object sender, EventArgs e)
        {
            VerificarBiometria();
        }

        private void VerificarBiometria()
        {
            PortariaBiometriaVerificar.Verificar(Usuario);
        }
    }
}
