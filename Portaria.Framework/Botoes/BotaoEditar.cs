using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoEditar : Button
    {
        public BotaoEditar()
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

            Image = Properties.Resources.group_edit;
            ImageAlign = ContentAlignment.MiddleCenter;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BackColor = Color.White;
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
