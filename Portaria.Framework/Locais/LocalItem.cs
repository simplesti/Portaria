using Portaria.Core.Model.Cadastro;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Framework.Locais
{
    public partial class LocalItem : UserControl
    {
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
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(this.DisplayRectangle.Location,
                    new Size(this.Width - 1, this.Height - 1)));
        }

        private void lblNome_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            VisualizarLocalClick(sender, new LocalEventArgs(Local));
        }
    }
}
