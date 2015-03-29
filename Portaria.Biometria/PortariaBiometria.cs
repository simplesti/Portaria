using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework;
using Portaria.Framework.CaixaMensagem;

namespace Portaria.Biometria
{
    public partial class PortariaBiometria : FormBase
    {
        bool resultado = false;
        
        Pessoa pessoa = null;
        
        public PortariaBiometria()
        {
            InitializeComponent();
        }

        public PortariaBiometria(Pessoa pessoa) : this()
        {
            this.pessoa = pessoa;

            lblVerificarBiometria.Text = lblVerificarBiometria.Text.Replace("<pessoa>", this.pessoa.Nome);
        }

        public static bool Verificar(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                CaixaMensagem.Mostrar("Você precisa informar uma pessoa.", TipoCaixaMensagem.SomenteOK);

                return false;
            }

            using (var frm = new PortariaBiometria(pessoa))
            {
                frm.ShowDialog();
                
                if (frm.resultado == false)
                {
                    CaixaMensagem.Mostrar("Você não confirmou a biometría de " + pessoa.Nome + ".", TipoCaixaMensagem.SomenteOK);
                }

                return frm.resultado;
            }
        }

        private void botaoCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
