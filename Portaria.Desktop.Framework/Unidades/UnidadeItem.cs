using Portaria.Core.Model.CadastroMorador;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Unidades
{
    public partial class UnidadeItem : UserControl
    {
        private Unidade unidade;

        public Unidade Unidade
        {
            set
            {
                unidade = value;
                
                lblNumero.Text = unidade.Numero.ToString();
                lblBloco.Text = unidade.Bloco.Nome;
            }

            get
            {
                return unidade;
            }
        }

        public event EventHandler<UnidadeEventArgs> VisualizarProprietarioClick;

        public event EventHandler<UnidadeEventArgs> VisualizarUnidadeClick;

        public UnidadeItem()
        {
            InitializeComponent();
        }

        public UnidadeItem(Unidade unidade) : this()
        {
            Unidade = unidade;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(this.DisplayRectangle.Location, 
                    new Size(this.Width - 1, this.Height - 1)));
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            VisualizarProprietarioClick(sender, new UnidadeEventArgs(Unidade));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {
            VisualizarUnidadeClick(sender, new UnidadeEventArgs(Unidade));
        }
    }
}
