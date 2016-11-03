using MaterialSkin.Controls;

namespace Portaria.Desktop.Framework.Botoes
{
    public partial class BotaoViewMode : MaterialFlatButton
    {
        public bool ViewList { get; set; }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                
            }
        }

        public BotaoViewMode()
        {
            InitializeComponent();
            this.ViewList = false;
            base.Text = "Exibir Lista";

            Click += BotaoViewMode_Click;
        }

        private void BotaoViewMode_Click(object sender, System.EventArgs e)
        {
            this.ViewList = !this.ViewList;

            base.Text = this.ViewList ? "Exibir Ícones" : "Exibir Lista";
            this.Icon = this.ViewList ? Properties.Resources.ic_view_module_grey_24dp_1x : Properties.Resources.ic_view_list_grey_24dp_1x;
        }
    }
}
