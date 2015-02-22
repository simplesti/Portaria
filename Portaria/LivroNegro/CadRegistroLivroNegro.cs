using Portaria.Business;
using Portaria.Cadastro;
using Portaria.Core.Model;
using Portaria.Framework.Forms;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Core.Model.Cadastro;
using Portaria.Locais;
using Portaria.UnidadesBlocos;
using Portaria.Blocos;
using Portaria.Usuarios;

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
                if (registro.Pessoa != null)
                {
                    txtNomePessoa.Text = registro.Pessoa.Nome;
                }
            }
        }

        public CadRegistroLivroNegro()
        {
            InitializeComponent();

            Registro = new RegistroLivroNegro() { Data = DateTime.Now };

            txtData.Text = Registro.Data.ToString("dd/MM/yyyy HH:mm:ss");
            txtUsuario.Text = SessaoBus.Sessao().UsuarioLogado.Nome;
        }

        public CadRegistroLivroNegro(RegistroLivroNegro registro)
        {
            InitializeComponent();

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
            Registro.Mensagem = rtbMensagem.Text;

            var registroLivroNegroBus = new RegistroLivroNegroBus();
            registroLivroNegroBus.InserirOuAtualizar(Registro);

            Close();
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
            bsEntidades.DataSource = entidadeHelper.BuscaEntidades(Registro.Entidades).ToList();
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
    }
}
