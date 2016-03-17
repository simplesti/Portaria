using Portaria.Business;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Desktop.Framework.Tarefas;
using Portaria.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.Plugin
{
    public static class GerenciadorPlugins
    {
        public static event EventHandler UsuarioLogou;

        private static List<PortariaPlugin> plugins = new List<PortariaPlugin>();

        public static List<PortariaPlugin> Plugins { get { return plugins; } }

        public static void CarregarPlugins()
        {
            var pluginsDir = Application.StartupPath;

            var dlls = Directory.EnumerateFiles(pluginsDir, "Portaria.Plugin.*.dll");
            foreach (var dll in dlls)
            {
                var assembly = Assembly.LoadFrom(dll);
                var types = assembly.GetTypes();
                foreach (var t in types)
                {
                    if (t.IsSubclassOf(typeof(PortariaPlugin)))
                    {
                        var plugin = assembly.CreateInstance(t.FullName) as PortariaPlugin;
                        if (plugin != null)
                        {
                            Plugins.Add(plugin);
                        }
                    }
                }
            }
        }

        public static void LoginRealizado(object sender, EventArgs eventArgs)
        {
            if (UsuarioLogou != null)
            {
                UsuarioLogou(sender, eventArgs);
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

        public static IPortariaBus<T> Buscar<T>() where T : IEntidade
        {
            return PortariaBusFactory.Buscar<T>(SessaoAtual.Sessao);
        }
    }
}
