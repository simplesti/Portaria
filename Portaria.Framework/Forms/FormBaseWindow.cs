
namespace Portaria.Framework.Forms
{
    public partial class FormBaseWindow : FormBase
    {
        public FormBaseWindow()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
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
    }
}
