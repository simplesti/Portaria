
using Portaria.Business;
using Portaria.Config;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Forms
{
    public partial class FormBaseWindow : FormBase
    {
        public bool ConfiguracoesUsuarioVisivel
        {
            get { return ConfiguracoesUsuario.Visible; }
            set { ConfiguracoesUsuario.Visible = value; }
        }

        public FormBaseWindow()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get
            {
                return lblTitulo.Text;
            }
            set
            {
                lblTitulo.Text = value;
            }
        }

        private void Fechar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Minimizar_Click(object sender, System.EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void tableLayoutPanel2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        private void tableLayoutPanel2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        private void tableLayoutPanel2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        private void tableLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void Maximizar_Click(object sender, System.EventArgs e)
        {
            if (WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else
            {
                WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
        }

        private void botaoConfig_Click(object sender, System.EventArgs e)
        {
            if (SessaoAtual.Sessao != null)
            {
                using (var frm = new ConfiguracoesUsuario())
                {
                    frm.ShowDialog();
                }

                this.OnLoad(e);
                this.Refresh();
            }
        }

        private void Icone_Click(object sender, EventArgs e)
        {
            if (SessaoAtual.Sessao != null && SessaoAtual.Sessao.UsuarioLogado.Tipo == Core.TipoUsuario.Administrador)
            {
                using (var frm = new Configuracoes())
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
