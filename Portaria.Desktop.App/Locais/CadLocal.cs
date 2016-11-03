using Portaria.Business.Cadastro;
using Portaria.Core.Model.Cadastro;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.Forms;
using Portaria.Webcam;

namespace Portaria.Locais
{
    public partial class CadLocal : MaterialPortariaFormWindow
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
            var localBus = new LocalBus(SessaoAtual.Sessao);
            localBus.InserirOuAtualizar(Local);

            Close();
        }

        private void pbFoto_Click(object sender, System.EventArgs e)
        {
            if (SessaoAtual.Sessao.UsuarioLogado.Tipo ==Core.TipoUsuario.Administrador)
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
