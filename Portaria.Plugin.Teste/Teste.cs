using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Tarefas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Portaria.Plugins.Teste
{
    public class Teste : PortariaPlugin
    {
        PortariaTarefa pt = null;

        public Teste()
        {
            var tarefa = new Task(() =>
            {
                for (int i = 1; true; i++)
                {
                    Debug.WriteLine(string.Format("Teste {0}", i));
                }
            });

            pt = new Desktop.Framework.PortariaTarefa()
            {
                Nome = "Tarefa do plugin teste",
                Tarefa = tarefa
            };
        }

        public override string Nome
        {
            set { }
            get
            {
                return "Plugin de Teste";
            }
        }

        public override void Executar()
        {
            //GerenciadorTarefas.Tarefas.Add(pt);
            //pt.Iniciar();
        }

        public override void Parar()
        {
            //pt.Parar();
            //GerenciadorTarefas.Tarefas.Remove(pt);
        }
    }
}
