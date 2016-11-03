using Portaria.Data;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.CaixasDeMensagem;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Data.Entity.Migrations;
using System.Windows.Forms;

namespace Portaria.ConfiguradorBD
{
    public partial class ConfiguradorBancoDados : MaterialPortariaFormBase
    {
        private UtilBD utilBD = new UtilBD();

        public ConfiguradorBancoDados()
        {
            InitializeComponent();
            PopulaCombo();
        }

        private void PopulaCombo()
        {
            cboTipoServidor.Items.Add(TipoBD.SQLServer);
            cboTipoServidor.Items.Add(TipoBD.MySQL);
        }

        private void Testar()
        {
            var str = utilBD.GerarConnString(txtUsuarioServidor.Text, txtSenhaServidor.Text, txtEnderecoServidor.Text);
            if (utilBD.TestarConexao(str))
            {
                CaixaMensagem.Mostrar("Conexão bem sucedida!", TipoCaixaMensagem.SomenteOK);
                cboBaseDados.DataSource = utilBD.ListarBases(str);
                btnSalvar.Visible = true;
            }
            else
            {
                CaixaMensagem.Mostrar("Erro ao conectar ao servidor. Verifique as configurações.", TipoCaixaMensagem.SomenteOK);
                btnSalvar.Visible = false;
            }
        }

        private void botaoTestarConexao_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Testar();

            Cursor = Cursors.Default;
        }

        private void botaoAdicionarBase_Click(object sender, EventArgs e)
        {
            AdicionaNovaBase();
        }

        private void AdicionaNovaBase()
        {
            var nome = CaixaEntrada.Mostrar("Nome da nova base:");

            Cursor = Cursors.WaitCursor;

            var str = utilBD.GerarConnString(txtUsuarioServidor.Text, txtSenhaServidor.Text, txtEnderecoServidor.Text);

            if (utilBD.CriarBases(nome, str))
            {
                CaixaMensagem.Mostrar("Base criada com sucesso!", TipoCaixaMensagem.SomenteOK);
                cboBaseDados.DataSource = utilBD.ListarBases(str);
            }
            else
            {
                CaixaMensagem.Mostrar("Erro ao criar nova base.", TipoCaixaMensagem.SomenteOK);
            }

            Cursor = Cursors.Default;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            if (CaixaMensagem.Mostrar("Você precisa informar uma base de dados válida para continuar com o sistema. Deseja realmente cancelar?", TipoCaixaMensagem.OKCancelar) == DialogResult.OK)
            {
                Close();
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (CaixaMensagem.Mostrar("Deseja atualizar a base selecionada para a ultima versão e salvar as configurações?", TipoCaixaMensagem.OKCancelar) == DialogResult.OK)
                {
                    Salvar();

                    AtualizarBase();
                    
                    CaixaMensagem.Mostrar("Base de dados configurada com sucesso!", TipoCaixaMensagem.SomenteOK);

                    Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                CaixaMensagem.Mostrar("Erro ao configurar o banco de dados. Verifique as informações e tente de novo.", TipoCaixaMensagem.SomenteOK);
            }
        }

        private void AtualizarBase()
        {
            Cursor = Cursors.WaitCursor;

            var migratorConfig = new Portaria.Data.Migrations.Configuration();
            var connstr = utilBD.GerarConnString(txtUsuarioServidor.Text, txtSenhaServidor.Text, txtEnderecoServidor.Text, cboBaseDados.Text);

            migratorConfig.TargetDatabase = new System.Data.Entity.Infrastructure.DbConnectionInfo(connstr, "System.Data.SqlClient");
            var dbMigrator = new DbMigrator(migratorConfig);
            dbMigrator.Update();

            Cursor = Cursors.Default;
        }

        private void Salvar()
        {
            var str = utilBD.GerarConnString(txtUsuarioServidor.Text, txtSenhaServidor.Text, txtEnderecoServidor.Text);
            utilBD.SalvarConfig(str, cboBaseDados.Text);
        }

        private bool Validar()
        {
            var str = utilBD.GerarConnString(txtUsuarioServidor.Text, txtSenhaServidor.Text, txtEnderecoServidor.Text);

            if (!utilBD.TestarConexao(str))
            {
                return false;
            }

            return true;
        }
    }
}
