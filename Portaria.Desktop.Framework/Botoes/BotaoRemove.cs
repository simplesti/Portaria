using Portaria.Desktop.Framework.Properties;
using System;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoRemove : UserControl
    {
        public BotaoRemove()
        {
            InitializeComponent();
        }

        private void BotaoRemove_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_delete_forever_grey_24dp_1x;
        }

        private void BotaoRemove_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_delete_forever_black_24dp_1x;
        }
    }
}
