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
    public partial class BotaoMudarVisao : Button
    {
        public BotaoMudarVisao()
        {
            InitializeComponent();
            CustomizaBotao();
        }

        private void CustomizaBotao()
        {
            ImageAlign = ContentAlignment.MiddleLeft;
            Image = Properties.Resources.Jumelles;
            TextAlign = ContentAlignment.MiddleRight;
            Cursor = Cursors.Hand;
            Size = new System.Drawing.Size(100, 35);
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BackColor = Color.White;
        }

        public override string Text
        {
            get
            {
                return "";
            }
            set
            {

            }
        }
    }
}
