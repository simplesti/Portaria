using Portaria.Business;
using Portaria.Core;
using Portaria.Desktop.Framework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Portaria.Core.Model;

namespace Portaria.LivroNegro
{
    public partial class TabVisualizarLivroNegro : PortariaTabBase
    {
        public TabVisualizarLivroNegro()
        {
            InitializeComponent();
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador, TipoUsuario.SomenteLeitura };
            }
        }

        private void botaoPesquisar_Click(object sender, System.EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            var registroLivroNegroBus = new RegistroLivroNegroBus(SessaoAtual.Sessao);

            var query = registroLivroNegroBus.Todos().Where(r => r.Mensagem.ToUpper()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            bsRegistros.DataSource = query.ToList();
        }

        private void txtPesquisar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                Pesquisar();
            }
        }

        private void botaoAdicionar_Click(object sender, System.EventArgs e)
        {
            Adicionar();
        }

        private void Adicionar()
        {
            using (var frm = new CadRegistroLivroNegro())
            {
                frm.ShowDialog();
            }
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count == 1)
            {
                VisualizarRegistro();
            }
        }

        private void VisualizarRegistro()
        {
            var registro = (RegistroLivroNegro)dgvRegistros.CurrentRow.DataBoundItem;

            using (var frm = new CadRegistroLivroNegro(registro))
            {
                frm.ShowDialog();
            }
        }
    }
}
