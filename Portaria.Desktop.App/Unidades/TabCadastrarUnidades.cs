using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria.Unidades
{
    public partial class TabCadastrarUnidades : PortariaTabBase
    {
        public TabCadastrarUnidades()
        {
            InitializeComponent();

            if (!Util.IsInDesignMode())
            {
                CarregarUnidades();
            }
        }

        private void CarregarUnidades()
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            bsUnidades.DataSource = unidadeBus.Todos().ToList();
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
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
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var u = unidadeBus.BuscarPorId(id);

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
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var u = unidadeBus.BuscarPorId(id);

            using (var frm = new CadUnidade(u))
            {
                frm.ShowDialog();
            }

            dgvUnidades.DataSource = unidadeBus.Todos().ToList();
        }

        private void AdicionarUnidade()
        {
            using (var frm = new CadUnidade())
            {
                frm.ShowDialog();
            }

            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
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
