using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoRemover : Button
    {
        public BotaoRemover()
        {
            InitializeComponent();
            CustomizaBotao();
        }

        private void CustomizaBotao()
        {
            var s = new System.Drawing.Size(24, 24);
            Size = s;
            MaximumSize = s;
            MinimumSize = s;

            Image = Properties.Resources.remover;
            ImageAlign = ContentAlignment.MiddleCenter;
            BackColor = Color.White;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AutoSize = true;
            Cursor = Cursors.Hand;
        }

        public override string Text
        {
            get
            {
                return string.Empty;
            }
            set
            {

            }
        }
    }
}
