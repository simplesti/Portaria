using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria.Blocos
{
    public partial class TabCadastrarBlocos : PortariaTabBase
    {
        public TabCadastrarBlocos()
        {
            InitializeComponent();

            if (!Util.IsInDesignMode())
            {
                CarregarBlocos();
            }
        }

        private void CarregarBlocos()
        {
            var blocoBus = new BlocoBus(SessaoAtual.Sessao);

            bsBlocos.DataSource = blocoBus.Todos().ToList();
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
            if (dgvBlocos.SelectedRows.Count == 1)
            {
                RemoverBloco();
            }
        }

        private void RemoverBloco()
        {
            var id = int.Parse(dgvBlocos.SelectedRows[0].Cells[0].Value.ToString());
            var blocoBus = new BlocoBus(SessaoAtual.Sessao);
            var b = blocoBus.BuscarPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover o bloco " + b.Nome + " ?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                blocoBus.Remover(b);

                dgvBlocos.DataSource = blocoBus.Todos().ToList();
            }
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarBloco();
        }

        private void EditarBloco()
        {
            var id = int.Parse(dgvBlocos.SelectedRows[0].Cells[0].Value.ToString());
            var blocoBus = new BlocoBus(SessaoAtual.Sessao);
            var b = blocoBus.BuscarPorId(id);

            using (var frm = new CadBloco(b))
            {
                frm.ShowDialog();
            }

            dgvBlocos.DataSource = blocoBus.Todos().ToList();
        }

        private void AdicionarBloco()
        {
            using (var frm = new CadBloco())
            {
                frm.ShowDialog();
            }

            var blocoBus = new BlocoBus(SessaoAtual.Sessao);
            dgvBlocos.DataSource = blocoBus.Todos().ToList();
        }


        private void dgvBlocos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBlocos.SelectedRows.Count == 1)
            {
                EditarBloco();
            }
        }
    }
}
