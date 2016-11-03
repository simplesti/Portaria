using Portaria.Core.Model.CadastroMorador;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Blocos
{
    public partial class BlocoItem : UserControl
    {
        private Bloco bloco;

        public Bloco Bloco
        {
            get
            {
                return bloco;
            }

            set
            {
                bloco = value;

                lblBloco.Text = bloco.Nome;
            }
        }

        public event EventHandler<BlocoEventArgs> VisualizarBlocoClick;

        public BlocoItem()
        {
            InitializeComponent();
        }

        public BlocoItem(Bloco bloco)
            : this()
        {
            this.Bloco = bloco;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(this.DisplayRectangle.Location,
                    new Size(this.Width - 1, this.Height - 1)));
        }

        private void lblBloco_Click(object sender, EventArgs e)
        {
            VisualizarBlocoClick(sender, new BlocoEventArgs(Bloco));
        }
    }
}
