using Portaria.Business;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using Portaria.LivroNegro;
using Portaria.Locais;
using Portaria.Login;
using Portaria.Servicos;
using Portaria.Visitantes;
using System;
using System.Windows.Forms;

namespace Portaria
{
    public partial class Principal : MaterialPortariaFormWindow
    {
        public Principal()
        {
            InitializeComponent();

            EfetuarLogin();

            LincarBolhas();
        }

        private void LincarBolhas()
        {
            tabInicio.VisualizarUnidades += (s, e) => { SelecionarTab(typeof(TabVisualizarUnidades)); };
            tabInicio.VisualizarReservas += (s, e) => { SelecionarTab(typeof(TabReservarLocais)); };
            tabInicio.VisualizarLivroNegro += (s, e) => { SelecionarTab(typeof(TabVisualizarLivroNegro)); };
            tabInicio.VisualizarVisitantes += (s, e) => { SelecionarTab(typeof(TabVisitantes)); };
            tabInicio.VisualizarServicos += (s, e) => { SelecionarTab(typeof(TabServicos)); };
        }

        private void SelecionarTab(Type tab)
        {
            foreach (TabPage tp in tabControl.Controls)
            {
                if (tp.Controls.Count > 0)
                {
                    if (tp.Controls[0].GetType().Name == tab.Name)
                    {
                        tabControl.SelectedTab = tp;
                    }
                }
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CaixaMensagem.Mostrar("Deseja efetuar logoff e sair do Portaria Digital?", TipoCaixaMensagem.OKCancelar) == DialogResult.OK)
            {
                EfetuarLogoff();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void EfetuarLogoff()
        {
            var sessaoBus = new SessaoBus();
            sessaoBus.FinalizarSessao(SessaoAtual.Sessao);
            SessaoAtual.Sessao = null;
        }

        private void EfetuarLogin()
        {
            var efetuarLogin = new EfetuarLogin();
            efetuarLogin.ShowDialog();

            if (SessaoAtual.Sessao == null)
            {
                Environment.Exit(0);
            }
        }

        private void Configuracoes_Click(object sender, EventArgs e)
        {
            if (SessaoAtual.Sessao != null && SessaoAtual.Sessao.UsuarioLogado.Tipo == Core.TipoUsuario.Administrador)
            {
                using (var frm = new Configuracoes())
                {
                    frm.ShowDialog();
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tabControl.ValidaPermissoes();
        }
    }
}
