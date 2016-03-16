using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Desktop.Framework
{
    public class PortariaTarefa
    {
        public string Nome { get; set; }
        public Task Tarefa { get; set; }

        public void Iniciar()
        {
            Tarefa.Start();
        }

        public void Parar()
        {
            Tarefa.Dispose();
        }
    }
}
