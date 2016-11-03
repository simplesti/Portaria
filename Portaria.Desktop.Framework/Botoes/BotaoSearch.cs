using Portaria.Desktop.Framework.Properties;
using System;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoSearch : UserControl
    {
        public BotaoSearch()
        {
            InitializeComponent();
        }

        private void BotaoSearch_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_search_grey_24dp_1x;
        }

        private void BotaoSearch_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_search_black_24dp_1x;
        }
    }
}
