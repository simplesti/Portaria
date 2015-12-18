using Portaria.Business;
using Portaria.Core;
using Portaria.Desktop.Framework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Core.Model;
using Portaria.Desktop.Framework;

namespace Portaria.Usuarios
{
    public partial class TabVisualizarUsuarios : PortariaTabBase
    {
        public TabVisualizarUsuarios()
        {
            InitializeComponent();

            if (!Util.IsInDesignMode())
            {
                CarregarUsuarios();
            }
        }

        private void CarregarUsuarios()
        {
            var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);
            bsUsuario.DataSource = usuarioBus.Todos().ToList();
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
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
            var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);
            var u = usuarioBus.BuscarPorId(id);

            using (var frm = new CadUsuario(u))
            {
                frm.ShowDialog();
            }

            dgvUsuarios.DataSource = usuarioBus.Todos().ToList();
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

            var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);
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
            var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);
            var u = usuarioBus.BuscarPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover o usuário " + u.Nome + " ?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                usuarioBus.Remover(u);

                dgvUsuarios.DataSource = usuarioBus.Todos().ToList();
            }
        }
    }
}
