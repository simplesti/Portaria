using Portaria.Desktop.Framework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework.CaixaMensagem
{
    public enum TipoCaixaMensagem
    {
        SomenteOK = 1,
        SomenteCancelar = 2,
        OKCancelar = 3
    }
    public partial class CaixaMensagem : MaterialPortariaFormBase
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
                            frm.btnOk.Visible = true;
                            break;
                        }
                    case TipoCaixaMensagem.SomenteCancelar:
                        {
                            frm.btnCancelar.Location = new Point(451, 217);
                            frm.btnCancelar.Visible = true;
                            break;
                        }
                    case TipoCaixaMensagem.SomenteOK:
                        {
                            frm.btnOk.Location = new Point(550, 217);
                            frm.btnOk.Visible = true;
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
