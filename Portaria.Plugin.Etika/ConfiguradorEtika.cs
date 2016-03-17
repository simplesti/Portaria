using Portaria.Core.Model;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.Plugin;
using System;
using System.Linq;

namespace Portaria.Plugin.Etika
{
    public partial class ConfiguradorEtika : FormBase
    {
        public ConfiguradorEtika()
        {
            InitializeComponent();

            CarregaDados();
        }

        private void CarregaDados()
        {
            var configuracaoBus = GerenciadorPlugins.Buscar<Configuracao>();

            var usuario = configuracaoBus.Todos().FirstOrDefault(q => q.Nome == "Etika.Usuario");
            if (usuario != null)
            {
                txtUsuario.Text = usuario.Valor;
            }
            var senha = configuracaoBus.Todos().FirstOrDefault(q => q.Nome == "Etika.Senha");
            if (senha != null)
            {
                txtSenha.Text = senha.Valor;
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

            Close();
        }

        private void Salvar()
        {
            var configuracaoBus = GerenciadorPlugins.Buscar<Configuracao>();

            var usuario = configuracaoBus.Todos().FirstOrDefault(q => q.Nome == "Etika.Usuario");
            if (usuario != null)
            {
                usuario.Valor = txtUsuario.Text;
            }
            else
            {
                usuario = new Configuracao() { Valor = txtUsuario.Text, Nome = "Etika.Usuario" };
            }
            configuracaoBus.InserirOuAtualizar(usuario);
            
            var senha = configuracaoBus.Todos().FirstOrDefault(q => q.Nome == "Etika.Senha");
            if (senha != null)
            {
                senha.Valor = txtSenha.Text;
            }
            else
            {
                senha = new Configuracao() { Valor = txtSenha.Text, Nome = "Etika.Senha" };
            }
            configuracaoBus.InserirOuAtualizar(senha);
        }
    }
}
