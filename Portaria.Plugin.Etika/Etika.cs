using Portaria.Desktop.Framework.Plugin;
using Portaria.Plugin.Etika;
using System.Linq;

namespace Portaria.Plugins.Etika
{
    public class Etika : PortariaPlugin
    {
        private EtikaGarimpadorWeb garimpador = null;

        private void Garimpador_GarimpouDados(object sender, EtikaGarimpadorWebEventArgs e)
        {
            if (e.UnidadesInadimplentes.Any())
            {
                var importador = new EtikaImportador();
                importador.ImportarInadimplencia(e.UnidadesInadimplentes);
            }
        }

        public override string Nome
        {
            get
            {
                return "Etika Gestão Condominal";
            }
        }

        public override void Executar()
        {
            GerenciadorPlugins.UsuarioLogou += GerenciadorPlugins_UsuarioLogou;
        }

        private void GerenciadorPlugins_UsuarioLogou(object sender, System.EventArgs e)
        {
            ExecutarGarimpador();
        }

        private void ExecutarGarimpador()
        {
            garimpador = new EtikaGarimpadorWeb();
            garimpador.GarimpouDados += Garimpador_GarimpouDados;
            garimpador.Garimpar();
        }

        public override void Parar()
        {
            if (garimpador != null)
            {
                garimpador.Dispose();
                garimpador = null;
            }
        }

        public override void Ajustar()
        {
            using (var frm = new ConfiguradorEtika())
            {
                frm.ShowDialog();
            }
        }
    }
}
