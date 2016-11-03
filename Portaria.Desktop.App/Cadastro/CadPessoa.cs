using Portaria.Biometria;
using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.Forms;
using Portaria.Webcam;
using System;
using System.Drawing;

namespace Portaria
{
    public partial class CadPessoa : MaterialPortariaFormWindow
    {
        private Pessoa pessoa;

        public Pessoa Pessoa
        {
            get
            {
                return pessoa;
            }

            set
            {
                pessoa = value;
                bsPessoa.DataSource = pessoa;
                if (pessoa.Foto != null)
                {
                    pbFoto.Image = Util.byteArrayToImage(pessoa.Foto);
                }

                if (pessoa.Biometria != null)
                {
                    lblStatusBiometria.Text = "BIOMETRIA CAPTURADA";
                    lblStatusBiometria.ForeColor = Color.DarkGreen;
                    btnVerificarBio.Enabled = true;
                }
                else
                {
                    lblStatusBiometria.Text = "BIOMETRIA NÃO CAPTURADA";
                    lblStatusBiometria.ForeColor = Color.DarkRed;
                    btnVerificarBio.Enabled = false;
                }
            }
        }

        public CadPessoa()
        {
            InitializeComponent();
            Pessoa = new Pessoa() { ControleAcessoAutorizado = true };
        }

        public CadPessoa(Pessoa pessoa)
        {
            InitializeComponent();
            Pessoa = pessoa;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var foto = PortariaWebCam.ObterImagem();
            if (foto != null)
            {
                pbFoto.Image = foto;
                pessoa.Foto = Util.imageToByteArray(foto);
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var pessoaBus = new PessoaBus(SessaoAtual.Sessao);
            pessoaBus.InserirOuAtualizar(Pessoa);

            Close();
        }

        private void CapturarBiometria()
        {
            var biometria = PortariaBiometriaCapturar.Capturar();
            if (biometria != null)
            {
                Pessoa.Biometria = biometria;

                lblStatusBiometria.Text = "BIOMETRIA CAPTURADA";
                lblStatusBiometria.ForeColor = Color.DarkGreen;

                btnVerificarBio.Enabled = true;
            }
        }

        private void botaoCapturarBiometria_Click(object sender, EventArgs e)
        {
            CapturarBiometria();
        }

        private void botaoVerificarBiometria_Click(object sender, EventArgs e)
        {
            VerificarBiometria();
        }

        private void VerificarBiometria()
        {
            PortariaBiometriaVerificar.Verificar(Pessoa);
        }
    }
}
