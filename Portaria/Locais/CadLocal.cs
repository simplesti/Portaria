using Portaria.Business.Cadastro;
using Portaria.Core.Model.Cadastro;
using Portaria.Framework;
using Portaria.Framework.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Locais
{
    public partial class CadLocal : FormBaseWindow
    {
        private Local local;

        public Local Local
        {
            get
            {
                return local;
            }
            set
            {
                local = value;
                bsLocal.DataSource = local;
                if (local.Foto != null)
                {
                    pbFoto.Image = Util.byteArrayToImage(local.Foto);
                }
            }
        }
        public CadLocal()
        {
            InitializeComponent();
            Local = new Local();
        }

        public CadLocal(Local local)
        {
            InitializeComponent();
            Local = local;
        }

        private void botaoCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, System.EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var localBus = new LocalBus();
            localBus.InserirOuAtualizar(Local);

            Close();
        }

        private void pbFoto_Click(object sender, System.EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pbFoto.Image = new Bitmap(ofd.FileName);
                    local.Foto = Util.imageToByteArray(pbFoto.Image);
                }
            }
        }

    }
}
