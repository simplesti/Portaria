using Portaria.Desktop.Framework.Tarefas;
using Portaria.Plugins;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Plugin
{
    public static class GerenciadorPlugins
    {
        private static List<PortariaPlugin> plugins = new List<PortariaPlugin>();

        public static List<PortariaPlugin> Plugins { get { return plugins; } }

        public static void CarregarPlugins()
        {
            var pluginsDir = Application.StartupPath + @"\Plugins\";

            var dlls = Directory.EnumerateFiles(pluginsDir, "Portaria.Plugin.*.dll");
            foreach (var dll in dlls)
            {
                var assembly = Assembly.LoadFrom(dll);
                var types = assembly.GetTypes();
                foreach (var t in types)
                {
                    var plugin = assembly.CreateInstance(t.FullName) as PortariaPlugin;
                    if (plugin != null)
                    {
                        Plugins.Add(plugin);
                    }
                }
            }
        }

        public static void IniciarPlugins()
        {
            foreach (var plugin in Plugins)
            {
                plugin.Executar();
            }
        }

        public static void PararPlugins()
        {
            foreach (var plugin in Plugins)
            {
                plugin.Parar();
            }
        }
    }
}
