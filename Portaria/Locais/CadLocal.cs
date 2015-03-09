using Portaria.Business;
using Portaria.Business.Cadastro;
using Portaria.Core.Model.Cadastro;
using Portaria.Framework;
using Portaria.Framework.Forms;
using Portaria.Webcam;
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
            if (SessaoBus.Sessao().UsuarioLogado.Tipo ==Core.TipoUsuario.Administrador)
            {
                var foto = PortariaWebCam.ObterImagem();
                if (foto != null)
                {
                    pbFoto.Image = foto;
                    local.Foto = Util.imageToByteArray(foto);
                }
            }
        }

    }
}
