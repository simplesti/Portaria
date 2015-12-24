using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.CaixasDeMensagem
{
    public partial class CaixaEntrada : FormBase
    {
        public static string Mostrar(string mensagem)
        {
            using (var frm = new CaixaEntrada())
            {
                frm.lblMensagem.Text = mensagem;
                frm.ShowDialog();

                return frm.txtRetorno.Text;
            }
        }

        public CaixaEntrada()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            txtRetorno.Text = string.Empty;
            Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
