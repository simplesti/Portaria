using Portaria.Business;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Framework.Forms;
using System.Collections.Generic;

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
            }
        }

        public CadUsuario()
        {
            InitializeComponent();
            PopulaComboTipo();
            Usuario = new Usuario();
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
            var usuarioBus = new UsuarioBus();
            usuarioBus.InserirOuAtualizar(Usuario);

            Close();
        }
    }
}
