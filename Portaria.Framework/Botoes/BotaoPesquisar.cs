using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Framework.Botoes
{
    public partial class BotaoPesquisar : Button
    {
        public BotaoPesquisar()
        {
            InitializeComponent();
            CustomizaBotao();
        }

        private void CustomizaBotao()
        {
            var s = new System.Drawing.Size(32, 32);
            Size = s;
            MaximumSize = s;
            MinimumSize = s;

            Image = Properties.Resources.search;
            ImageAlign = ContentAlignment.MiddleCenter;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AutoSize = true;
            BackColor = Color.White;
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
