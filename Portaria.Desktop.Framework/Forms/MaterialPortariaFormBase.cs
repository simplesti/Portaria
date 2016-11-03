using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Forms
{
    public partial class MaterialPortariaFormBase : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public MaterialPortariaFormBase()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
