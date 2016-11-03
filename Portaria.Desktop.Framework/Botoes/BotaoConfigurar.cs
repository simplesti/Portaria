using Portaria.Desktop.Framework.Properties;
using System;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoConfigurar : UserControl
    {
        public BotaoConfigurar()
        {
            InitializeComponent();
        }

        private void BotaoConfigurar_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_settings_grey_24dp_1x;
        }

        private void BotaoConfigurar_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_settings_black_24dp_1x;
        }
    }
}
