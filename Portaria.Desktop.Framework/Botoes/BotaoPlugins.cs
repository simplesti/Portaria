using Portaria.Desktop.Framework.Properties;
using System;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoPlugins : UserControl
    {
        public BotaoPlugins()
        {
            InitializeComponent();
        }

        private void BotaoPlugins_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_settings_input_component_grey_24dp_1x;
        }

        private void BotaoPlugins_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = BackgroundImage = Resources.ic_settings_input_component_black_24dp_1x;
        }
    }
}
