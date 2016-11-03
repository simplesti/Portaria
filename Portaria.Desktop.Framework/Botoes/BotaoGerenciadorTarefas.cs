using Portaria.Desktop.Framework.Properties;
using System;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoGerenciadorTarefas : UserControl
    {
        public BotaoGerenciadorTarefas()
        {
            InitializeComponent();
        }

        private void BotaoGerenciadorTarefas_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_assignment_grey_24dp_1x;
        }

        private void BotaoGerenciadorTarefas_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.ic_assignment_black_24dp_1x;
        }
    }
}
