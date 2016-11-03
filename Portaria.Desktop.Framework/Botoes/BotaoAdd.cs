using Portaria.Desktop.Framework.Properties;
using System;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoAdd : UserControl
    {
        public BotaoAdd()
        {
            InitializeComponent();
        }

        private void BotaoAdd_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_add_circle_grey_24dp_1x;
        }

        private void BotaoAdd_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_add_circle_black_24dp_1x;
        }
    }
}
