using Portaria.Desktop.Framework.Forms;
using Portaria.Plugins;

namespace Portaria.Desktop.Framework.Plugin
{
    public partial class VisualizarPlugins : FormBaseWindow
    {
        public VisualizarPlugins()
        {
            InitializeComponent();
            portariaPluginBindingSource.DataSource = GerenciadorPlugins.Plugins;
        }

        private void dgvPlugins_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            var plugin = dgvPlugins.Rows[e.RowIndex].DataBoundItem as PortariaPlugin;
            if (plugin != null)
            {
                plugin.Ajustar();
            }
        }
    }
}
