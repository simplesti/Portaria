using Portaria.Business;
using Portaria.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Portaria.Config
{
    public partial class ConfiguracoesUsuario : FormBase
    {
        public ConfiguracoesUsuario()
        {
            InitializeComponent();

            PopulaComboCores();
        }

        private void PopulaComboCores()
        {
            var esquemas = new Dictionary<string, Int32>();
            esquemas.Add("Cinza Claro", -657931);
            esquemas.Add("Branco Sujo", -657956);
            esquemas.Add("Bege Claro", -31);
            esquemas.Add("Branco", -1);

            if (SessaoBus.Sessao().UsuarioLogado.Tipo == Core.TipoUsuario.Administrador)
            {
                esquemas.Add("Administrador", -983056);
            }

            cboCor.DisplayMember = "Key";
            cboCor.ValueMember = "Value";
            cboCor.DataSource = esquemas.ToList();
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
            var usuarioBus = new UsuarioBus();
            var u = usuarioBus.BuscaPorId(SessaoBus.Sessao().UsuarioLogado.Id);

            u.CorTema = (Int32)cboCor.SelectedValue;

            usuarioBus.InserirOuAtualizar(u);

            SessaoBus.Sessao().UsuarioLogado = u;
        }
    }
}
