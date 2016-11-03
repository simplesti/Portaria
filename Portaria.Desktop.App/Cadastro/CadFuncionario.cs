using Portaria.Biometria;
using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.Forms;
using Portaria.Webcam;
using System;
using System.Drawing;

namespace Portaria.UnidadesBlocos
{
    public partial class CadFuncionario : MaterialPortariaFormWindow
    {
        private Funcionario funcionario;

        public Funcionario Funcionario
        {
            get
            {
                return funcionario;
            }
            set
            {
                funcionario = value;
                bsFuncionario.DataSource = funcionario;
                if (funcionario.Foto != null)
                {
                    pbFoto.Image = Util.byteArrayToImage(funcionario.Foto);
                }

                if (funcionario.Biometria != null)
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

        public CadFuncionario()
        {
            InitializeComponent();
            Funcionario = new Funcionario() { ControleAcessoAutorizado = true };

        }

        public CadFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            Funcionario = funcionario;
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
            var funcionarioBus = new FuncionarioBus(SessaoAtual.Sessao);
            funcionarioBus.InserirOuAtualizar(Funcionario);

            Close();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            var foto = PortariaWebCam.ObterImagem();
            if (foto != null)
            {
                pbFoto.Image = foto;
                funcionario.Foto = Util.imageToByteArray(foto);
            }
        }
        private void CapturarBiometria()
        {
            var biometria = PortariaBiometriaCapturar.Capturar();
            if (biometria != null)
            {
                Funcionario.Biometria = biometria;

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
            PortariaBiometriaVerificar.Verificar(Funcionario);
        }
    }
}
