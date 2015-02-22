﻿using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework.Forms;
using System.Windows.Forms;
using System.Linq;
using Portaria.Framework.CaixaMensagem;

namespace Portaria.Cadastro
{
    public partial class SelecionaPessoa : FormBaseWindow
    {
        private Pessoa pessoaSelecionada = null;
        public SelecionaPessoa()
        {
            InitializeComponent();
        }

        public static Pessoa Selecionar(Pessoa pessoa = null)
        {
            using (var frm = new SelecionaPessoa())
            {
                if (pessoa != null)
                {
                    frm.txtPesquisar.Text = pessoa.Nome;
                    frm.Pesquisar();
                }

                frm.ShowDialog();

                return frm.pessoaSelecionada;
            }
        }

        private void dgvPessoas_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dgvPessoas.SelectedRows.Count == 1)
            {
                pessoaSelecionada = (Pessoa)dgvPessoas.CurrentRow.DataBoundItem;
            }
        }

        private void botaoPesquisar_Click(object sender, System.EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            var pessoaBus = new PessoaBus();
            var query = pessoaBus.BuscaPorNome(txtPesquisar.Text).AsQueryable();

            if (chkSomente30.Checked)
            {
                query = query.Take(30);
            }

            bsPessoas.DataSource = query.ToList();
        }

        private void txtPesquisar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                Pesquisar();
            }
        }

        private void botaoCancelar_Click(object sender, System.EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            if (CaixaMensagem.Mostrar("Você não selecionou nenhuma pessoa. Deseja continuar?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                pessoaSelecionada = null;
                Close();
            }
        }

        private void botaoOK_Click(object sender, System.EventArgs e)
        {
            SelecionarPessoa();
        }

        private void SelecionarPessoa()
        {
            if (pessoaSelecionada != null)
            {
                Close();
            }
            else
            {
                CaixaMensagem.Mostrar("Selecione uma pessoa.", TipoCaixaMensagem.SomenteOK);
            }
        }

        private void botaoAdicionar_Click(object sender, System.EventArgs e)
        {
            Adicionar();
        }

        private void Adicionar()
        {
            using (var frm = new CadPessoa())
            {
                frm.ShowDialog();
            }

            Pesquisar();
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPessoas.SelectedRows.Count == 1)
            {
                pessoaSelecionada = (Pessoa)dgvPessoas.CurrentRow.DataBoundItem;

                using (var frm = new CadPessoa(pessoaSelecionada))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}