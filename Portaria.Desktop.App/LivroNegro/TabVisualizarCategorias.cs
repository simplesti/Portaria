using Portaria.Business;
using Portaria.Core;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria.LivroNegro
{
    public partial class TabVisualizarCategorias : PortariaTabBase
    {
        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador };
            }
        }

        public TabVisualizarCategorias()
        {
            InitializeComponent();

            if (!Util.IsInDesignMode())
            {
                CarregaCategorias();
            }
        }

        public void CarregaCategorias()
        {
            var categoriaBus = new CategoriaLivroNegroBus(SessaoAtual.Sessao);
            bsCategorias.DataSource = categoriaBus.Todos().ToList();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 1)
            {
                EditarCategoria();
            }
        }

        private void EditarCategoria()
        {
            var id = int.Parse(dgvCategorias.SelectedRows[0].Cells[0].Value.ToString());
            var categoriaBus = new CategoriaLivroNegroBus(SessaoAtual.Sessao);
            var c = categoriaBus.BuscarPorId(id);

            using (var frm = new CadCategoriaLivroNegro(c))
            {
                frm.ShowDialog();
            }

            dgvCategorias.DataSource = categoriaBus.Todos().ToList();
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarCategoria();
        }

        private void AdicionarCategoria()
        {
            using (var frm = new CadCategoriaLivroNegro())
            {
                frm.ShowDialog();
            }

            var categoriaBus = new CategoriaLivroNegroBus(SessaoAtual.Sessao);
            dgvCategorias.DataSource = categoriaBus.Todos().ToList();
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 1)
            {
                RemoverCategoria();
            }
        }

        private void RemoverCategoria()
        {
            var id = int.Parse(dgvCategorias.SelectedRows[0].Cells[0].Value.ToString());
            var categoriaBus = new CategoriaLivroNegroBus(SessaoAtual.Sessao);
            var c = categoriaBus.BuscarPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover a categoria " + c.Nome + " ?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                categoriaBus.Remover(c);

                dgvCategorias.DataSource = categoriaBus.Todos().ToList();
            }
        }
    }
}
