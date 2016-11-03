using Portaria.Desktop.Framework.Properties;
using System;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoPessoa : UserControl
    {
        public BotaoPessoa()
        {
            InitializeComponent();
        }

        private void BotaoPessoa_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_person_grey_24dp_1x;
        }

        private void BotaoPessoa_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_person_black_24dp_1x;
        }
    }
}
