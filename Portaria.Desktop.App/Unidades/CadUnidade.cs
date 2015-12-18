using Portaria.Business;
using Portaria.Business.Cadastro;
using Portaria.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.UnidadesBlocos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portaria
{
    public partial class CadUnidade : Portaria.Desktop.Framework.Forms.FormBaseWindow
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

                chkInadimplente.Checked = unidade.Inadimplente;

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
            var blocoBus = new BlocoBus(SessaoAtual.Sessao);
            cboBloco.DataSource = blocoBus.Todos().ToList();
        }

        public CadUnidade()
        {
            InitializeComponent();
            PopulaCombos();

            txtNumero.ReadOnly = false;
            cboBloco.Enabled = true;

            Unidade = new Unidade();

            AplicarPermissoes();
        }

        private void AplicarPermissoes()
        {
            if (SessaoAtual.Sessao.UsuarioLogado.Tipo != Core.TipoUsuario.Administrador)
            {
                botaoSalvar.Visible = false;

                btnAddAutorizada.Visible = false;
                btnRemAutorizada.Visible = false;

                btnAddFuncionario.Visible = false;
                btnRemFuncionario.Visible = false;

                btnAddVeiculo.Visible = false;
                btnRemVeiculo.Visible = false;

                chkInadimplente.Enabled = false;
            }
        }

        public CadUnidade(Unidade unidade)
        {
            InitializeComponent();
            PopulaCombos();

            Unidade = unidade;

            AplicarPermissoes();
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
            unidade.Inadimplente = chkInadimplente.Checked;

            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
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

            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            unidadeBus.InserirOuAtualizar(Unidade);

            Unidade = unidadeBus.BuscarPorId(Unidade.Id);
        }

        private void EditarConjuge()
        {
            if (unidade.Id == 0)
            {
                Salvar();
            }

            Unidade.Conjuge = SelecionaPessoa.Selecionar(Unidade.Conjuge);

            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            unidadeBus.InserirOuAtualizar(Unidade);

            Unidade = unidadeBus.BuscarPorId(Unidade.Id);
        }

        private void EditarLocatario()
        {
            if (unidade.Id == 0)
            {
                Salvar();
            }

            Unidade.Locatario = SelecionaPessoa.Selecionar(Unidade.Locatario);

            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            unidadeBus.InserirOuAtualizar(Unidade);

            Unidade = unidadeBus.BuscarPorId(Unidade.Id);
        }

        private void btnAddAutorizada_Click(object sender, EventArgs e)
        {
            AdicionarPessoaAutorizada();
        }

        private void AdicionarPessoaAutorizada()
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var u = unidadeBus.BuscarPorId(Unidade.Id);

            if (Unidade.Id == 0)
            {
                unidadeBus.InserirOuAtualizar(Unidade);
            }

            var p = SelecionaPessoa.Selecionar();

            unidadeBus.AdicionarAutorizado(p, Unidade);

            CarregarAutorizados();
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
            var pessoaBus = new PessoaBus(SessaoAtual.Sessao);
            var p = pessoaBus.BuscarPorId(id);

            using (var frm = new CadPessoa(p))
            {
                frm.ShowDialog();
            }

            CarregarAutorizados();
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
            var pessoaBus = new PessoaBus(SessaoAtual.Sessao);
            var p = pessoaBus.BuscarPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover " + p.Nome + " das pessoas autorizadas desta unidade?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
                unidadeBus.RemoverAutorizado(p, Unidade);

                CarregarAutorizados();
            }
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario();
        }

        private void AdicionarFuncionario()
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var f = new Funcionario();
            var u = unidadeBus.BuscarPorId(Unidade.Id);

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

            CarregarFuncionarios();
        }

        private void btnRemFuncionario_Click(object sender, EventArgs e)
        {
            RemoverFuncionario();
        }

        private void RemoverFuncionario()
        {
            var id = int.Parse(dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
            var funcionarioBus = new FuncionarioBus(SessaoAtual.Sessao);
            var f = funcionarioBus.BuscarPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover " + f.Nome + " dos funcionários desta unidade?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                funcionarioBus.Remover(f);

                CarregarFuncionarios();
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
            var veiculoBus = new VeiculoBus(SessaoAtual.Sessao);
            var v = veiculoBus.BuscarPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover " + v.Nome + " dos veículos desta unidade?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                veiculoBus.Remover(v);

                CarregarVeiculos();
            }
        }

        private void AdicionarVeiculo()
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var v = new Veiculo();
            var u = unidadeBus.BuscarPorId(Unidade.Id);

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

            CarregarVeiculos();
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
            var veiculoBus = new VeiculoBus(SessaoAtual.Sessao);
            var v = veiculoBus.BuscarPorId(id);

            using (var frm = new CadVeiculo(v))
            {
                frm.ShowDialog();
            }

            CarregarVeiculos();
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
            var funcionarioBus = new FuncionarioBus(SessaoAtual.Sessao);
            var f = funcionarioBus.BuscarPorId(id);

            using (var frm = new CadFuncionario(f))
            {
                frm.ShowDialog();
            }

            CarregarFuncionarios();
        }

        private void CarregarVeiculos()
        {
            var veiculoBus = new VeiculoBus(SessaoAtual.Sessao);
            var veiculos = veiculoBus.BuscarPorUnidade(unidade.Id).ToList();
            dgvVeiculos.DataSource = veiculos;
        }

        private void CarregarFuncionarios()
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var funcionarios = unidadeBus.BuscarFuncionarios(unidade.Id).ToList();
            dgvFuncionarios.DataSource = funcionarios;
        }
        
        private void CarregarAutorizados()
        {
            var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);
            var autorizados = unidadeBus.BuscarAutorizados(unidade.Id).ToList();
            dgvAutorizadas.DataSource = autorizados;
        }
    }
}
