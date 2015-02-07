using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portaria.Core;
using Portaria.Business.Cadastro;
using Portaria.Framework.CaixaMensagem;

namespace Portaria.Unidades
{
    public partial class TabCadastrarUnidades : UserControl
    {
        public TabCadastrarUnidades()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                CarregarUnidades();
            }
        }

        private void CarregarUnidades()
        {
            var unidadeBus = new UnidadeBus();
            bsUnidades.DataSource = unidadeBus.Todos().ToList();
        }

        public ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador };
            }
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (dgvUnidades.SelectedRows.Count == 1)
            {
                RemoverUnidade();
            }
        }

        private void RemoverUnidade()
        {
            var id = int.Parse(dgvUnidades.SelectedRows[0].Cells[0].Value.ToString());
            var unidadeBus = new UnidadeBus();
            var u = unidadeBus.BuscaPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover a unidade" + u.Numero.ToString() + " ?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                unidadeBus.Remover(u);

                dgvUnidades.DataSource = unidadeBus.Todos().ToList();
            }
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarUnidade();
        }

        private void EditarUnidade()
        {
            var id = int.Parse(dgvUnidades.SelectedRows[0].Cells[0].Value.ToString());
            var unidadeBus = new UnidadeBus();
            var u = unidadeBus.BuscaPorId(id);

            using (var frm = new CadUnidade(u))
            {
                frm.ShowDialog();
            }

            dgvUnidades.Refresh();
        }

        private void AdicionarUnidade()
        {
            using (var frm = new CadUnidade())
            {
                frm.ShowDialog();
            }

            var unidadeBus = new UnidadeBus();
            dgvUnidades.DataSource = unidadeBus.Todos().ToList();
        }

        private void dgvUnidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUnidades.SelectedRows.Count == 1)
            {
                EditarUnidade();
            }
        }
    }
}
