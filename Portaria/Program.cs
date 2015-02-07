using Portaria.Framework.CaixaMensagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria
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

            Application.Run(new Principal());
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            CaixaMensagem.Mostrar(e.Exception.Message, Framework.CaixaMensagem.TipoCaixaMensagem.SomenteOK);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            CaixaMensagem.Mostrar((e.ExceptionObject as Exception).Message, Framework.CaixaMensagem.TipoCaixaMensagem.SomenteOK);
        }
    }
}
