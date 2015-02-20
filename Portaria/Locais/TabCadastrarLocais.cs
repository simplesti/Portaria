using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Framework.CaixaMensagem;
using Portaria.Framework.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Portaria.Locais
{
    public partial class TabCadastrarLocais : PortariaTabBase
    {
        public TabCadastrarLocais()
        {
            InitializeComponent();
            
            if (!DesignMode)
            {
                CarregarLocais();
            }
        }

        private void CarregarLocais()
        {
            var localBus = new LocalBus();

            bsLocais.DataSource = localBus.Todos().ToList();
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador };
            }
        }

        private void botaoAdicionar_Click(object sender, System.EventArgs e)
        {
            AdicionarLocal();
        }

        private void botaoRemover_Click(object sender, System.EventArgs e)
        {
            if (dgvLocais.SelectedRows.Count == 1)
            {
                RemoverLocal();
            }
        }

        private void EditarLocal()
        {
            var id = int.Parse(dgvLocais.SelectedRows[0].Cells[0].Value.ToString());
            var localBus = new LocalBus();
            var l = localBus.BuscaPorId(id);

            using (var frm = new CadLocal(l))
            {
                frm.ShowDialog();
            }

            dgvLocais.Refresh();
        }

        private void AdicionarLocal()
        {
            using (var frm = new CadLocal())
            {
                frm.ShowDialog();
            }

            var localBus = new LocalBus();
            dgvLocais.DataSource = localBus.Todos().ToList();
        }

        private void RemoverLocal()
        {
            var id = int.Parse(dgvLocais.SelectedRows[0].Cells[0].Value.ToString());
            var localBus = new LocalBus();
            var l = localBus.BuscaPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover o local " + l.Nome + " ?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                localBus.Remover(l);

                dgvLocais.DataSource = localBus.Todos().ToList();
            }
        }

        private void dgvLocais_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvLocais.SelectedRows.Count == 1)
            {
                EditarLocal();
            }
        }
    }
}
