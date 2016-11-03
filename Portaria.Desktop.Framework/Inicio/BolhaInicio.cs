using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Inicio
{
    public partial class BolhaInicio : UserControl
    {
        private Color color = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.DarkPrimaryColor;

        public BolhaInicio()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public Image Icone
        {
            get
            {
                return pic.Image;
            }

            set
            {
                pic.Image = value;
            }
        }

        public string Texto
        {
            get
            {
                return lblTexto.Text;
            }

            set
            {
                lblTexto.Text = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(new Point(), new Size(this.Width - 1, this.Height - 1));
            e.Graphics.FillEllipse(new SolidBrush(color), rect);

            lblTexto.ForeColor = Color.White;
            base.OnPaint(e);
        }

        private void lblTexto_MouseEnter(object sender, EventArgs e)
        {
            color = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            Cursor = Cursors.Hand;
            Refresh();
        }

        private void lblTexto_MouseLeave(object sender, EventArgs e)
        {
            color = MaterialSkin.MaterialSkinManager.Instance.ColorScheme.DarkPrimaryColor;
            Cursor = Cursors.Default;
            Refresh();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void pic_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
