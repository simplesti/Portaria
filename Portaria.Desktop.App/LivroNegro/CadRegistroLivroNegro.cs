using Portaria.Biometria;
using Portaria.Blocos;
using Portaria.Business;
using Portaria.Cadastro;
using Portaria.Core.Model;
using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.Forms;
using Portaria.Locais;
using Portaria.UnidadesBlocos;
using Portaria.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria.LivroNegro
{
    public partial class CadRegistroLivroNegro : FormBaseWindow
    {
        private RegistroLivroNegro registro;

        public RegistroLivroNegro Registro
        {
            get
            {
                return registro;
            }

            set
            {
                registro = value;
                rtbMensagem.Text = registro.Mensagem;
                cboCategoria.SelectedItem = registro.Categoria;
                if (registro.Pessoa != null)
                {
                    txtNomePessoa.Text = registro.Pessoa.Nome;
                }
            }
        }

        public CadRegistroLivroNegro()
        {
            InitializeComponent();
            CarregarCategorias();

            Registro = new RegistroLivroNegro() { Data = DateTime.Now };

            txtData.Text = Registro.Data.ToString("dd/MM/yyyy HH:mm:ss");
            txtUsuario.Text = SessaoAtual.Sessao.UsuarioLogado.Nome;
        }

        public CadRegistroLivroNegro(RegistroLivroNegro registro)
        {
            InitializeComponent();
            CarregarCategorias();

            Registro = registro;

            txtData.Text = Registro.Data.ToString("dd/MM/yyyy HH:mm:ss");
            txtUsuario.Text = Registro.Sessao.UsuarioLogado.Nome;

            PopulaEntidades();

            rtbMensagem.ReadOnly = true;
            botaoAdicionar.Enabled = false;
            botaoRemover.Enabled = false;
            botaoSalvar.Enabled = false;
            botaoEditarPessoa.Enabled = false;
        }

        private void botaoCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, System.EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            if (PortariaBiometriaVerificar.Verificar(Registro.Pessoa))
            {
                Registro.Categoria = cboCategoria.SelectedItem as CategoriaLivroNegro;
                Registro.Mensagem = rtbMensagem.Text;

                var registroLivroNegroBus = new RegistroLivroNegroBus(SessaoAtual.Sessao);
                registroLivroNegroBus.InserirOuAtualizar(Registro);

                Close();
            }
        }

        private void botaoEditarPessoa_Click(object sender, System.EventArgs e)
        {
            Registro.Pessoa = SelecionaPessoa.Selecionar();

            if (Registro.Pessoa != null)
            {
                txtNomePessoa.Text = Registro.Pessoa.Nome;
            }
            else
            {
                txtNomePessoa.Text = string.Empty;
            }
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarEntidade();
        }

        private void AdicionarEntidade()
        {
            var entidade = SelecionaEntidade.Selecionar();

            if (entidade != null)
            {
                if (Registro.Entidades == null)
                {
                    Registro.Entidades = new List<RegistroLivroNegroEntidade>();
                }

                Registro.Entidades.Add(new RegistroLivroNegroEntidade() { IdEntidade = entidade.Id, Tipo = entidade.TipoEntidade });
                PopulaEntidades();
            }
        }

        private void PopulaEntidades()
        {
            var entidadeHelper = new EntidadeHelper();
            bsEntidades.DataSource = entidadeHelper.BuscarEntidades(Registro.Entidades).ToList();
            dgvEntidades.Columns[0].Visible = false;
        }

        private void MostraEntidade(IEntidade entidade)
        {
            if (entidade.TipoEntidade == typeof(Pessoa).Name)
            {
                using (var frm = new CadPessoa((Pessoa)entidade))
                {
                    frm.ShowDialog();
                }
            }
            else if (entidade.TipoEntidade == typeof(Veiculo).Name)
            {
                using (var frm = new CadVeiculo((Veiculo)entidade))
                {
                    frm.ShowDialog();
                }
            }
            else if (entidade.TipoEntidade == typeof(Unidade).Name)
            {
                using (var frm = new CadUnidade((Unidade)entidade))
                {
                    frm.ShowDialog();
                }
            }
            else if (entidade.TipoEntidade == typeof(Local).Name)
            {
                using (var frm = new CadReserva((Local)entidade))
                {
                    frm.ShowDialog();
                }
            }
            else if (entidade.TipoEntidade == typeof(Funcionario).Name)
            {
                using (var frm = new CadFuncionario((Funcionario)entidade))
                {
                    frm.ShowDialog();
                }
            }
            else if (entidade.TipoEntidade == typeof(Bloco).Name)
            {
                using (var frm = new CadBloco((Bloco)entidade))
                {
                    frm.ShowDialog();
                }
            }
            else if (entidade.TipoEntidade == typeof(Usuario).Name)
            {
                using (var frm = new CadUsuario((Usuario)entidade))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            RemoverEntidade();
        }

        private void RemoverEntidade()
        {
            if (dgvEntidades.SelectedRows.Count == 1)
            {
                var entidadeSelecionada = (IEntidade)dgvEntidades.CurrentRow.DataBoundItem;

                var registroEntidade = Registro.Entidades.FirstOrDefault(r => r.IdEntidade == entidadeSelecionada.Id && r.Tipo == entidadeSelecionada.TipoEntidade);
                if (registroEntidade != null)
                {
                    Registro.Entidades.Remove(registroEntidade);
                    PopulaEntidades();
                }
            }
        }

        private void dgvEntidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntidades.SelectedRows.Count == 1)
            {
                var entidadeSelecionada = (IEntidade)dgvEntidades.CurrentRow.DataBoundItem;

                MostraEntidade(entidadeSelecionada);
            }
        }

        private void CarregarCategorias()
        {
            if (!Util.IsInDesignMode())
            {
                var categoriaBus = new CategoriaLivroNegroBus(SessaoAtual.Sessao);
                var categorias = categoriaBus.Todos().ToList();
                cboCategoria.DataSource = categorias;
            }
        }
    }
}
