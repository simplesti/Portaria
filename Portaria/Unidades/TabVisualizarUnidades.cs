using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework.Forms;
using Portaria.Framework.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria
{
    public partial class TabVisualizarUnidades : PortariaTabBase
    {
        public TabVisualizarUnidades()
        {
            InitializeComponent();
        }

        private void CarregarTodasUnidades()
        {
            var unidadeBus = new UnidadeBus();
            var query = unidadeBus.Todos();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            PopulaUnidades(query.ToList());
        }

        private void PopulaUnidades(IEnumerable<Unidade> unidades)
        {
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

        public override void Carregar(params Core.Model.IModel[] entidades)
        {
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
            var unidadeBus = new UnidadeBus();

            var query = unidadeBus.Todos().AsQueryable();
            query = query.Where(e => ids.Contains(e.Id));

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

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

            if (numero != 0)
            {
                var unidadeBus = new UnidadeBus();
                var query = unidadeBus.BuscarPorNumero(numero).AsQueryable();

                if (chkSomente30.Checked)
                {
                    query = query.Take(30);
                }

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
    }
}
