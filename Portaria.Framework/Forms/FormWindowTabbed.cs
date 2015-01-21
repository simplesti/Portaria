using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Framework.Forms
{
    public partial class FormWindowTabbed : FormBaseWindow
    {
        public FormWindowTabbed()
        {
            InitializeComponent();
        }

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            var tab = e.Control as TabPage;
            if (tab != null)
            {
                tab.ControlAdded += tab_ControlAdded;
            }
        }

        void tab_ControlAdded(object sender, ControlEventArgs e)
        {
            /*if (e.Control.GetType() != typeof(IPortariaTab))
            {
                var tab = e.Control.Parent;
                tab.Controls.Remove(e.Control);

                throw new Exception("O controle inserido não é do tipo IPortariaTab.");
            }*/
        }
    }
}
