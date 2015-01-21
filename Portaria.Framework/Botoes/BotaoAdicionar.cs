using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Framework.Botoes
{
    public partial class BotaoAdicionar : Button
    {
        public BotaoAdicionar()
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

            Image = Properties.Resources.adicionar;
            ImageAlign = ContentAlignment.MiddleCenter;
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
