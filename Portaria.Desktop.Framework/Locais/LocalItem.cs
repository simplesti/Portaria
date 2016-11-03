using Portaria.Core.Model.Cadastro;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Locais
{
    public partial class LocalItem : UserControl
    {
        private Color color = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.DarkPrimaryColor;

        private Local local;

        public Local Local
        {
            get
            {
                return local;
            }
            set
            {
                local = value;
                lblNome.Text = local.Nome;
            }
        }

        public event EventHandler<LocalEventArgs> VisualizarLocalClick;

        private void lblNome_MouseEnter(object sender, EventArgs e)
        {
            color = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            Cursor = Cursors.Hand;
            Refresh();
        }

        private void lblNome_MouseLeave(object sender, EventArgs e)
        {
            color = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.DarkPrimaryColor;
            Cursor = Cursors.Default;
            Refresh();
        }

        public LocalItem()
        {
            InitializeComponent();
        }

        public LocalItem(Local local)
            : this()
        {
            Local = local;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            lblNome.BackColor = color;

            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(this.DisplayRectangle.Location,
                    new Size(this.Width - 1, this.Height - 1)));
            
            lblNome.ForeColor = Color.White;
            base.OnPaint(e);
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            VisualizarLocalClick(sender, new LocalEventArgs(Local));
        }
    }
}
