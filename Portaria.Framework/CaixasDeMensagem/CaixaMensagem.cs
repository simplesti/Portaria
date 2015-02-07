using Portaria.Framework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Framework.CaixaMensagem
{
    public enum TipoCaixaMensagem
    {
        SomenteOK = 1,
        SomenteCancelar = 2,
        OKCancelar = 3
    }
    public partial class CaixaMensagem : FormBase
    {
        private DialogResult resultado = DialogResult.None;
        public CaixaMensagem()
        {
            InitializeComponent();
        }

        public static DialogResult Mostrar(string mensagem,TipoCaixaMensagem tipo)
        {
            using (var frm = new CaixaMensagem())
            {
                frm.lblMensagem.Text = mensagem;

                switch (tipo)
                {
                    case TipoCaixaMensagem.OKCancelar:
                        {
                            frm.btnCancelar.Visible = true;
                            frm.btnOK.Visible = true;
                            break;
                        }
                    case TipoCaixaMensagem.SomenteCancelar:
                        {
                            frm.btnCancelar.Location = new Point(250, 153);
                            frm.btnCancelar.Visible = true;
                            break;
                        }
                    case TipoCaixaMensagem.SomenteOK:
                        {
                            frm.btnOK.Location = new Point(250, 153);
                            frm.btnOK.Visible = true;
                            break;
                        }
                }

                frm.ShowDialog();
                return frm.resultado;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resultado = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            resultado = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
