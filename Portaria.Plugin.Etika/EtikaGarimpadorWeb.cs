using Portaria.Core.Model;
using Portaria.Desktop.Framework.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Portaria.Plugin.Etika
{
    public class EtikaGarimpadorWeb : IDisposable
    {
        private WebBrowser wb = null;

        public event EventHandler<EtikaGarimpadorWebEventArgs> GarimpouDados;

        private string usuario = null;
        private string senha = null;

        public EtikaGarimpadorWeb()
        {
            var configuracaoBus = GerenciadorPlugins.Buscar<Configuracao>();

            var u = configuracaoBus.Todos().FirstOrDefault(q => q.Nome == "Etika.Usuario");
            if (u != null)
            {
                usuario = u.Valor;
            }
            var s = configuracaoBus.Todos().FirstOrDefault(q => q.Nome == "Etika.Senha");
            if (s != null)
            {
                senha = s.Valor;
            }
        }

        public void Garimpar()
        {
            if (usuario == null || senha == null)
            {
                return;
            }

            wb = new WebBrowser();
            wb.DocumentCompleted += LoginCompletado;

            string PostHeaders = "Content-Type: application/x-www-form-urlencoded";
            ASCIIEncoding Encode = new ASCIIEncoding();
            byte[] post = Encode.GetBytes("LOGIN=" + usuario + "&SENHA=" + senha);

            wb.Navigate("http://site1368534208.hospedagemdesites.ws/prg/crLogin.php", null, post, PostHeaders);
        }

        private void LoginCompletado(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var numMes = DateTime.Now.Month.ToString("00");
            wb.Navigate("http://site1368534208.hospedagemdesites.ws/prg/exibeDoc.php?id=5270&btn=Exibir%20" + numMes + "/2016&PROD=C&ASSESSOR=JOSIE&ASSESSOR_EMAIL=josie@etikacondominios.com.br&TIPO=Cond%C3%B4mino&CHAVE=00137UNC&DESC_SERV=CONDOM%C3%8DNIO%20RESIDENCIAL%20GERMANIA%20LIFE%20PRINCIPAL&t=1458175725482");

            wb.DocumentCompleted += ExtratoCarregado;
        }

        private void ExtratoCarregado(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wb.Stop();

            var divInadimplentes = wb.Document.GetElementById("tem_inadimp");
            if (divInadimplentes != null)
            {
                GarimparDados(divInadimplentes);
            }
        }

        private void GarimparDados(HtmlElement divInadimplentes)
        {
            var retorno = new List<string>();

            foreach (HtmlElement elemento in divInadimplentes.GetElementsByTagName("SPAN")[2].Children[0].Children[0].GetElementsByTagName("TR"))
            {
                if (elemento.TagName.Equals("TR"))
                {
                    var registro = elemento.GetElementsByTagName("TD")[1].InnerText;
                    if (registro.Trim(' ') != "TOTAL DE INADIMPLENCIA")
                    {
                        retorno.Add(registro);
                    }
                }
            }

            wb.Dispose();

            if (GarimpouDados != null)
            {
                var strInadimplencias = retorno.Distinct().ToList<string>();
                var numUnidadesInadimplentes = strInadimplencias.Select(s => int.Parse(s.Substring(0, 3))).ToArray();

                GarimpouDados(this, new EtikaGarimpadorWebEventArgs(numUnidadesInadimplentes));
            }
        }

        public void Dispose()
        {
            if (wb != null)
            {
                wb.Dispose();
            }
        }
    }
}
