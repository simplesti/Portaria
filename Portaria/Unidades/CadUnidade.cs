using Portaria.Business.Cadastro;
using Portaria.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework.CaixaMensagem;
using Portaria.UnidadesBlocos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portaria
{
    public partial class CadUnidade : Portaria.Framework.Forms.FormBaseWindow
    {
        private Unidade unidade;

        public Unidade Unidade
        {
            get
            {
                return unidade;
            }

            set
            {
                unidade = value;

                txtNumero.Text = unidade.Numero.ToString();

                if (unidade.DataAtualizacao.HasValue)
                {
                    lblDtAtualizacao.Text = unidade.DataAtualizacao.Value.ToString("dd/MM/yyyy HH:mm");
                }

                if (unidade.Bloco != null)
                {
                    cboBloco.SelectedItem = unidade.Bloco;
                }

                if (unidade.Locatario != null)
                {
                    txtLocatario.Tag = unidade.Locatario.Id;
                    txtLocatario.Text = unidade.Locatario.Nome;
                }

                if (unidade.Proprietario != null)
                {
                    txtProprietario.Tag = unidade.Proprietario.Id;
                    txtProprietario.Text = unidade.Proprietario.Nome;
                }

                if (unidade.Conjuge != null)
                {
                    txtConjuge.Tag = unidade.Conjuge.Id;
                    txtConjuge.Text = unidade.Conjuge.Nome;
                }

                dgvAutorizadas.DataSource = unidade.Autorizados.ToList();
                dgvFuncionarios.DataSource = unidade.Funcionarios.ToList();
                dgvVeiculos.DataSource = unidade.Veiculos.ToList();

                txtAnimais.Text = unidade.Animais;
                txtAssinaturas.Text = unidade.Assinaturas;
                txtGas.Text = unidade.AparelhosGas;
                txtObs.Text = unidade.Observacoes;
            }
        }

        private void PopulaCombos()
        {
            var blocoBus = new BlocoBus();
            cboBloco.DataSource = blocoBus.Todos().ToList();
        }

        public CadUnidade()
        {
            InitializeComponent();
            PopulaCombos();

            txtNumero.ReadOnly = false;
            cboBloco.Enabled = true;

            Unidade = new Unidade();
        }

        public CadUnidade(Unidade unidade)
        {
            InitializeComponent();
            PopulaCombos();

            Unidade = unidade;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            Close();
        }

        private void botaoEditarProprietario_Click(object sender, EventArgs e)
        {
            EditarProprietario();
        }

        private void botaoEditarConjuge_Click(object sender, EventArgs e)
        {
            EditarConjuge();
        }

        private void botaoEditarLocatario_Click(object sender, EventArgs e)
        {
            EditarLocatario();
        }

        private void Salvar()
        {
            unidade.Animais = txtAnimais.Text;
            unidade.Assinaturas = txtAssinaturas.Text;
            unidade.AparelhosGas = txtGas.Text;
            unidade.Observacoes = txtObs.Text;
            unidade.Bloco = (Bloco)cboBloco.SelectedItem;
            unidade.Numero = int.Parse(txtNumero.Text);

            var unidadeBus = new UnidadeBus();
            unidadeBus.InserirOuAtualizar(Unidade);

            Close();
        }

        private void EditarProprietario()
        {
            if (unidade.Id == 0)
            {
                Salvar();
            }

            Unidade.Proprietario = SelecionaPessoa.Selecionar(Unidade.Proprietario);

            var unidadeBus = new UnidadeBus();
            unidadeBus.InserirOuAtualizar(Unidade);

            Unidade = unidadeBus.BuscaPorId(Unidade.Id);
        }

        private void EditarConjuge()
        {
            if (unidade.Id == 0)
            {
                Salvar();
            }

            Unidade.Conjuge = SelecionaPessoa.Selecionar(Unidade.Conjuge);

            var unidadeBus = new UnidadeBus();
            unidadeBus.InserirOuAtualizar(Unidade);

            Unidade = unidadeBus.BuscaPorId(Unidade.Id);
        }

        private void EditarLocatario()
        {
            if (unidade.Id == 0)
            {
                Salvar();
            }

            Unidade.Locatario = SelecionaPessoa.Selecionar(Unidade.Locatario);

            var unidadeBus = new UnidadeBus();
            unidadeBus.InserirOuAtualizar(Unidade);

            Unidade = unidadeBus.BuscaPorId(Unidade.Id);
        }

        private void btnAddAutorizada_Click(object sender, EventArgs e)
        {
            AdicionarPessoaAutorizada();
        }

        private void AdicionarPessoaAutorizada()
        {
            var unidadeBus = new UnidadeBus();
            var u = unidadeBus.BuscaPorId(Unidade.Id);

            if (Unidade.Id == 0)
            {
                unidadeBus.InserirOuAtualizar(Unidade);
            }

            var p = SelecionaPessoa.Selecionar();

            unidadeBus.AdicionarAutorizado(p, Unidade);

            dgvAutorizadas.DataSource = u.Autorizados.ToList();
        }

        private void dgvAutorizadas_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            if (dgvAutorizadas.SelectedRows.Count == 1)
            {
                EditarPessoaAutorizada();
            }
        }

        private void EditarPessoaAutorizada()
        {
            var id = int.Parse(dgvAutorizadas.SelectedRows[0].Cells[0].Value.ToString());
            var pessoaBus = new PessoaBus();
            var p = pessoaBus.BuscaPorId(id);

            using (var frm = new CadPessoa(p))
            {
                frm.ShowDialog();
            }

            dgvAutorizadas.Refresh();
        }

        private void btnRemAutorizada_Click(object sender, EventArgs e)
        {
            if (dgvAutorizadas.SelectedRows.Count == 1)
            {
                RemoverPessoaAutorizada();
            }
        }

        private void RemoverPessoaAutorizada()
        {
            var id = int.Parse(dgvAutorizadas.SelectedRows[0].Cells[0].Value.ToString());
            var pessoaBus = new PessoaBus();
            var p = pessoaBus.BuscaPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover " + p.Nome + " das pessoas autorizadas desta unidade?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                var unidadeBus = new UnidadeBus();
                unidadeBus.RemoverAutorizado(p, Unidade);

                dgvAutorizadas.DataSource = unidade.Autorizados.ToList();
            }
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario();
        }

        private void AdicionarFuncionario()
        {
            var unidadeBus = new UnidadeBus();
            var f = new Funcionario();
            var u = unidadeBus.BuscaPorId(Unidade.Id);

            if (Unidade.Id == 0)
            {
                unidadeBus.InserirOuAtualizar(Unidade);
            }

            using (var frm = new CadFuncionario(f))
            {
                frm.ShowDialog();
            }

            if (u.Funcionarios == null)
            {
                u.Funcionarios = new List<Funcionario>();
            }
            u.Funcionarios.Add(f);

            unidadeBus.InserirOuAtualizar(u);

            dgvFuncionarios.DataSource = u.Funcionarios.ToList();
        }

        private void btnRemFuncionario_Click(object sender, EventArgs e)
        {
            RemoverFuncionario();
        }

        private void RemoverFuncionario()
        {
            var id = int.Parse(dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
            var funcionarioBus = new FuncionarioBus();
            var f = funcionarioBus.BuscaPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover " + f.Nome + " dos funcionários desta unidade?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                funcionarioBus.Remover(f);

                dgvFuncionarios.DataSource = unidade.Funcionarios.ToList();
            }
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {
            AdicionarVeiculo();
        }

        private void btnRemVeiculo_Click(object sender, EventArgs e)
        {
            if (dgvVeiculos.SelectedRows.Count == 1)
            {
                RemoverVeiculo();
            }
        }

        private void RemoverVeiculo()
        {
            var id = int.Parse(dgvVeiculos.SelectedRows[0].Cells[0].Value.ToString());
            var veiculoBus = new VeiculoBus();
            var v = veiculoBus.BuscaPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover " + v.Nome + " dos veículos desta unidade?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                veiculoBus.Remover(v);

                dgvVeiculos.DataSource = unidade.Veiculos.ToList();
            }
        }

        private void AdicionarVeiculo()
        {
            var unidadeBus = new UnidadeBus();
            var v = new Veiculo();
            var u = unidadeBus.BuscaPorId(Unidade.Id);

            if (Unidade.Id == 0)
            {
                unidadeBus.InserirOuAtualizar(Unidade);
            }

            using (var frm = new CadVeiculo(v))
            {
                frm.ShowDialog();
            }

            if (u.Veiculos == null)
            {
                u.Veiculos = new List<Veiculo>();
            }
            u.Veiculos.Add(v);

            unidadeBus.InserirOuAtualizar(u);

            dgvVeiculos.DataSource = u.Veiculos.ToList();
        }

        private void dgvVeiculos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVeiculos.SelectedRows.Count == 1)
            {
                EditarVeiculo();
            }
        }

        private void EditarVeiculo()
        {
            var id = int.Parse(dgvVeiculos.SelectedRows[0].Cells[0].Value.ToString());
            var veiculoBus = new VeiculoBus();
            var v = veiculoBus.BuscaPorId(id);

            using (var frm = new CadVeiculo(v))
            {
                frm.ShowDialog();
            }

            dgvVeiculos.Refresh();
        }

        private void dgvFuncionarios_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count == 1)
            {
                EditarFuncionario();
            }
        }

        private void EditarFuncionario()
        {
            var id = int.Parse(dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
            var funcionarioBus = new FuncionarioBus();
            var f = funcionarioBus.BuscaPorId(id);

            using (var frm = new CadFuncionario(f))
            {
                frm.ShowDialog();
            }

            dgvFuncionarios.Refresh();
        }
    }
}
