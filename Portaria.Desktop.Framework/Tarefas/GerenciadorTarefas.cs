using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Desktop.Framework.Tarefas
{
    public static class GerenciadorTarefas
    {
        private static List<PortariaTarefa> tarefas = new List<PortariaTarefa>();
        public static List<PortariaTarefa> Tarefas { get { return tarefas; } }
    }
}
