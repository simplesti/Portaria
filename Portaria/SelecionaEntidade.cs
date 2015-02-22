using Portaria.Business;
using Portaria.Business.Cadastro;
using Portaria.Core.Model;
using Portaria.Framework.CaixaMensagem;
using Portaria.Framework.Forms;
using System;
using System.Linq;

namespace Portaria
{
    public partial class SelecionaEntidade : FormBaseWindow
    {
        private IEntidade entidadeSelecionada = null;
        public SelecionaEntidade()
        {
            InitializeComponent();

            CarregaTipos();
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
            switch (cboTipo.Text)
            {
                case "Pessoa":
                    {
                        PesquisarPessoa();
                        break;
                    }
                case "Veículo":
                    {
                        PesquisarVeiculo();
                        break;
                    }
                case "Unidade":
                    {
                        PesquisarUnidade();
                        break;
                    }
                case "Bloco":
                    {
                        PesquisarBloco();
                        break;
                    }
                case "Funcionário":
                    {
                        PesquisarFuncionario();
                        break;
                    }
                case "Local":
                    {
                        PesquisarLocal();
                        break;
                    }
                case "Usuário":
                    {
                        PesquisarUsuario();
                        break;
                    }
            }
        }

        private void PesquisarUsuario()
        {
            var usuarioBus = new UsuarioBus();
            var query = usuarioBus.Todos().Where(u => u.DescricaoEntidade().ToUpper()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            dgvEntidades.DataSource = query.Cast<IEntidade>().ToList();
        }

        private void PesquisarLocal()
        {
            var localBus = new LocalBus();
            var query = localBus.Todos().Where(u => u.DescricaoEntidade().ToUpper()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            dgvEntidades.DataSource = query.Cast<IEntidade>().ToList();
        }

        private void PesquisarFuncionario()
        {
            var funcionarioBus = new FuncionarioBus();
            var query = funcionarioBus.Todos().Where(u => u.DescricaoEntidade().ToUpper()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            dgvEntidades.DataSource = query.Cast<IEntidade>().ToList();
        }

        private void PesquisarBloco()
        {
            var blocoBus = new BlocoBus();
            var query = blocoBus.Todos().Where(u => u.DescricaoEntidade().ToUpper()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            dgvEntidades.DataSource = query.Cast<IEntidade>().ToList();
        }

        private void PesquisarUnidade()
        {
            var unidadeBus = new UnidadeBus();
            var query = unidadeBus.Todos().Where(u => u.Numero.ToString()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            dgvEntidades.DataSource = query.Cast<IEntidade>().ToList();
        }

        private void PesquisarVeiculo()
        {
            var veiculoBus = new VeiculoBus();
            var query = veiculoBus.Todos().Where(u => u.Placa.ToUpper()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            dgvEntidades.DataSource = query.Cast<IEntidade>().ToList();
        }

        private void PesquisarPessoa()
        {
            var pessoaBus = new PessoaBus();
            var query = pessoaBus.Todos().Where(u => u.Nome.ToUpper()
                .Contains(txtPesquisar.Text.ToUpper())).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            dgvEntidades.DataSource = query.Cast<IEntidade>().ToList();
        }
    }
}
