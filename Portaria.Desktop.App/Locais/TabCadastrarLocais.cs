﻿using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Portaria.Locais
{
    public partial class TabCadastrarLocais : PortariaTabBase
    {
        public TabCadastrarLocais()
        {
            InitializeComponent();

            if (!Util.IsInDesignMode())
            {
                CarregarLocais();
            }
        }

        private void CarregarLocais()
        {
            var localBus = new LocalBus(SessaoAtual.Sessao);

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
            var localBus = new LocalBus(SessaoAtual.Sessao);
            var l = localBus.BuscarPorId(id);

            using (var frm = new CadLocal(l))
            {
                frm.ShowDialog();
            }

            dgvLocais.DataSource = localBus.Todos().ToList();
        }

        private void AdicionarLocal()
        {
            using (var frm = new CadLocal())
            {
                frm.ShowDialog();
            }

            var localBus = new LocalBus(SessaoAtual.Sessao);
            dgvLocais.DataSource = localBus.Todos().ToList();
        }

        private void RemoverLocal()
        {
            var id = int.Parse(dgvLocais.SelectedRows[0].Cells[0].Value.ToString());
            var localBus = new LocalBus(SessaoAtual.Sessao);
            var l = localBus.BuscarPorId(id);

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
