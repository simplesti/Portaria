using Portaria.Desktop.Framework.CaixaMensagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.ConfiguradorBD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.Run(new ConfiguradorBancoDados());
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            CaixaMensagem.Mostrar(e.Exception.Message, Portaria.Desktop.Framework.CaixaMensagem.TipoCaixaMensagem.SomenteOK);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            CaixaMensagem.Mostrar((e.ExceptionObject as Exception).Message, Portaria.Desktop.Framework.CaixaMensagem.TipoCaixaMensagem.SomenteOK);
        }
    }
}
