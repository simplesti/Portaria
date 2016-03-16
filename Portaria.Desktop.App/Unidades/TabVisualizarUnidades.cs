using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework.Forms;
using Portaria.Desktop.Framework.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria
{
    public partial class TabVisualizarUnidades : PortariaTabBase
    {
        private bool pesquisaDetalhada;
        public bool PesquisaDetalhada
        {
            get
            {
                return this.pesquisaDetalhada;
            }

            set
            {
                pesquisaDetalhada = value;

                flpUnidades.Visible = !pesquisaDetalhada;
                dgvUnidadesDetalhadas.Visible = pesquisaDetalhada;
            }
        }

        public TabVisualizarUnidades()
        {
            InitializeComponent();
        }

        private void CarregarTodasUnidades()
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var query = unidadeBus.Todos(chkSomente30.Checked);

            PopulaUnidades(query.ToList());
        }

        private void PopulaUnidades(IEnumerable<Unidade> unidades)
        {
            unidadeBindingSource.DataSource = unidades;

            flpUnidades.Controls.Clear();
            foreach (var unidade in unidades)
            {
                var u = new UnidadeItem(unidade);
                u.VisualizarProprietarioClick += u_VisualizarProprietarioClick;
                u.VisualizarUnidadeClick += u_VisualizarUnidadeClick;
                flpUnidades.Controls.Add(u);
            }
        }

        void u_VisualizarUnidadeClick(object sender, UnidadeEventArgs e)
        {
            using (var frm = new CadUnidade(e.Unidade))
            {
                frm.ShowDialog();
            }
        }

        void u_VisualizarProprietarioClick(object sender, UnidadeEventArgs e)
        {
            if (e.Unidade.Proprietario != null)
            {
                using (var frm = new CadPessoa(e.Unidade.Proprietario))
                {
                    frm.ShowDialog();
                }
            }
        }

        public override void Carregar(params Core.Model.IEntidade[] entidades)
        {
            base.Carregar();

            if (SessaoAtual.Sessao != null)
            {
                PesquisaDetalhada = SessaoAtual.Sessao.UsuarioLogado.PesquisaDetalhadaPadrao;
            }

            if (entidades.Any())
            {
                var tabPage = this.Parent as TabPage;
                if (tabPage != null)
                {
                    var tabControl = tabPage.Parent as TabControl;
                    if (tabControl != null)
                    {
                        tabControl.SelectedTab = tabPage;

                        CarregarUnidades(entidades.Select(e => e.Id));
                    }
                }
            }
            else
            {
                CarregarTodasUnidades();
            }
        }

        private void CarregarUnidades(IEnumerable<int> ids)
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var query = unidadeBus.BuscarPorIds(ids, chkSomente30.Checked);

            PopulaUnidades(query.ToList());
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador, TipoUsuario.SomenteLeitura };
            }
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(txtPesquisar.Text);
        }

        private void Pesquisar(string criterios)
        {
            if (string.IsNullOrEmpty(criterios))
            {
                CarregarTodasUnidades();
                return;
            }

            int numero;
            int.TryParse(criterios, out numero);

            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            if (numero != 0)
            {
                var query = unidadeBus.BuscarPorNumero(numero, chkSomente30.Checked).AsQueryable();

                PopulaUnidades(query.ToList());
            }
            else
            {
                var query = unidadeBus.BuscarPorPessoa(criterios, chkSomente30.Checked).AsQueryable();

                PopulaUnidades(query.ToList());
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                Pesquisar(txtPesquisar.Text);
                e.Handled = true;
            }
        }

        private void botaoMudarVisao_Click(object sender, EventArgs e)
        {
            PesquisaDetalhada = !PesquisaDetalhada;
        }

        private void dgvUnidadesDetalhadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvUnidadesDetalhadas.SelectedRows[0].Cells[0].Value.ToString());
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var unidade = unidadeBus.BuscarPorId(id);

            using (var frm = new CadUnidade(unidade))
            {
                frm.ShowDialog();
            }
        }
    }
}
