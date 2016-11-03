using Portaria.Desktop.Framework.Forms;
using Portaria.Desktop.Framework.Tarefas;

namespace Portaria.Desktop.Framework.Config
{
    public partial class VisualizarTarefas : MaterialPortariaFormWindow
    {
        public VisualizarTarefas()
        {
            InitializeComponent();
            portariaTarefaBindingSource.DataSource = GerenciadorTarefas.Tarefas;
        }
    }
}
