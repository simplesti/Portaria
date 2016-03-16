using Portaria.Desktop.Framework.Forms;
using Portaria.Desktop.Framework.Tarefas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Config
{
    public partial class VisualizarTarefas : FormBaseWindow
    {
        public VisualizarTarefas()
        {
            InitializeComponent();
            portariaTarefaBindingSource.DataSource = GerenciadorTarefas.Tarefas;
        }
    }
}
