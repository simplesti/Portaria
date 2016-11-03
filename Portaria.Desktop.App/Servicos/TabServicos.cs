using Portaria.Business;
using Portaria.Core;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Portaria.Servicos
{
    public partial class TabServicos : PortariaTabBase
    {
        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Porteiro };
            }
        }

        public TabServicos()
        {
            InitializeComponent();
            CarregarTipos();
        }

        private void CarregarTipos()
        {
            cboTipoServico.DataSource = new[]
            {
                TipoContatoServico.Outro,
                TipoContatoServico.Eletricista,
                TipoContatoServico.Hidraulica,
                TipoContatoServico.Jardim,
                TipoContatoServico.Pedreiro,
                TipoContatoServico.TvTelefoniaInternet
            };
        }

        private void txtPesquisa_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void Pesquisar()
        {
            var contatoServicoBus = new ContatoServicoBus(SessaoAtual.Sessao);
            bsListaContatoServico.DataSource = contatoServicoBus.Pesquisar(txtPesquisa.Text, (TipoContatoServico)cboTipoServico.SelectedValue);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void botaoAddServico_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void Adicionar()
        {
            using (var frm = new CadServico())
            {
                frm.ShowDialog();
            }

            Pesquisar();
        }

        private void dgvVisitantes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvVisitantes.SelectedRows.Count == 1)
            {
                EditarServico();
            }
        }

        private void EditarServico()
        {
            var id = int.Parse(dgvVisitantes.SelectedRows[0].Cells[0].Value.ToString());
            var contatoServicoBus = new ContatoServicoBus(SessaoAtual.Sessao);
            var c = contatoServicoBus.BuscarPorId(id);

            using (var frm = new CadServico(c))
            {
                frm.ShowDialog();
            }

            Pesquisar();
        }
    }
}
