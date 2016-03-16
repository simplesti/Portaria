using Portaria.Desktop.Framework.Forms;

namespace Portaria.Desktop.Framework.Plugin
{
    public partial class VisualizarPlugins : FormBaseWindow
    {
        public VisualizarPlugins()
        {
            InitializeComponent();
            portariaPluginBindingSource.DataSource = GerenciadorPlugins.Plugins;
        }
    }
}
