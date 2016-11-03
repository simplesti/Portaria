using Portaria.Business;
using Portaria.Core.Model;
using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Windows.Forms;

namespace Portaria
{
    public partial class SelecionaEntidade : MaterialPortariaFormWindow
    {
        private IEntidade entidadeSelecionada = null;

        public SelecionaEntidade()
        {
            InitializeComponent();

            CarregaTipos();
        }

        public SelecionaEntidade(string tipo)
            : this()
        {
            cboTipo.Text = tipo;
            cboTipo.Enabled = false;
        }

        private void CarregaTipos()
        {
            cboTipo.DataSource = new[] { "Pessoa", "Veículo", "Unidade", "Bloco", "Funcionário", "Local", "Usuário" };
        }

        public static IEntidade Selecionar()
        {
            using (var frm = new SelecionaEntidade())
            {
                frm.ShowDialog();

                return frm.entidadeSelecionada;
            }
        }

        public static Unidade SelecionarUnidade()
        {
            using (var frm = new SelecionaEntidade("Unidade"))
            {
                frm.ShowDialog();

                return (Unidade)frm.entidadeSelecionada;
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            if (CaixaMensagem.Mostrar("Você não selecionou nenhuma entidade. Deseja continuar?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                entidadeSelecionada = null;
                Close();
            }
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            SelecionarEntidade();
        }

        private void SelecionarEntidade()
        {
            if (entidadeSelecionada != null)
            {
                Close();
            }
            else
            {
                CaixaMensagem.Mostrar("Selecione uma entidade.", TipoCaixaMensagem.SomenteOK);
            }
        }

        private void dgvEntidades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntidades.SelectedRows.Count == 1)
            {
                entidadeSelecionada = (IEntidade)dgvEntidades.CurrentRow.DataBoundItem;
            }
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            var entidadeHelper = new EntidadeHelper();

            switch (cboTipo.Text)
            {
                case "Pessoa":
                    {
                        bsEntidades.DataSource = entidadeHelper.BuscarPorDescricao(txtPesquisar.Text, typeof(Pessoa).Name);
                        break;
                    }
                case "Veículo":
                    {
                        bsEntidades.DataSource = entidadeHelper.BuscarPorDescricao(txtPesquisar.Text, typeof(Veiculo).Name);
                        break;
                    }
                case "Unidade":
                    {
                        bsEntidades.DataSource = entidadeHelper.BuscarPorDescricao(txtPesquisar.Text, typeof(Unidade).Name);
                        break;
                    }
                case "Bloco":
                    {
                        bsEntidades.DataSource = entidadeHelper.BuscarPorDescricao(txtPesquisar.Text, typeof(Bloco).Name);
                        break;
                    }
                case "Funcionário":
                    {
                        bsEntidades.DataSource = entidadeHelper.BuscarPorDescricao(txtPesquisar.Text, typeof(Funcionario).Name);
                        break;
                    }
                case "Local":
                    {
                        bsEntidades.DataSource = entidadeHelper.BuscarPorDescricao(txtPesquisar.Text, typeof(Local).Name);
                        break;
                    }
                case "Usuário":
                    {
                        bsEntidades.DataSource = entidadeHelper.BuscarPorDescricao(txtPesquisar.Text, typeof(Usuario).Name);
                        break;
                    }
            }
        }

        private void txtPesquisar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                Pesquisar();
            }
        }
    }
}
