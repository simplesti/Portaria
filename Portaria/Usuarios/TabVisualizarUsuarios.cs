using Portaria.Business;
using Portaria.Core;
using Portaria.Framework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Portaria.Framework.CaixaMensagem;

namespace Portaria.Usuarios
{
    public partial class TabVisualizarUsuarios : UserControl, IPortariaTab
    {
        public TabVisualizarUsuarios()
        {
            InitializeComponent();

            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            var usuarioBus = new UsuarioBus();
            bsUsuario.DataSource = usuarioBus.Todos().ToList();
        }

        public ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get 
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador };
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                EditarUsuario();
            }
        }

        private void EditarUsuario()
        {
            var id = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            var usuarioBus = new UsuarioBus();
            var u = usuarioBus.BuscaPorId(id);

            using (var frm = new CadUsuario(u))
            {
                frm.ShowDialog();
            }

            dgvUsuarios.Refresh();
        }

        private void botaoAdicionar_Click(object sender, System.EventArgs e)
        {
            AdicionarUsuario();
        }

        private void AdicionarUsuario()
        {
            using (var frm = new CadUsuario())
            {
                frm.ShowDialog();
            }

            var usuarioBus = new UsuarioBus();
            dgvUsuarios.DataSource = usuarioBus.Todos().ToList();
        }

        private void botaoRemover_Click(object sender, System.EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                RemoverUsuario();
            }
        }

        private void RemoverUsuario()
        {
            var id = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            var usuarioBus = new UsuarioBus();
            var u = usuarioBus.BuscaPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover o usuário " + u.Nome + " ?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                usuarioBus.Remover(u);

                dgvUsuarios.DataSource = usuarioBus.Todos().ToList();
            }
        }
    }
}
