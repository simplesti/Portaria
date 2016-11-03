using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.Forms;
using Portaria.Webcam;
using System;

namespace Portaria.Cadastro
{
    public partial class CadVeiculo : MaterialPortariaFormWindow
    {
        private Veiculo veiculo;

        public Veiculo Veiculo
        {
            get
            {
                return veiculo;
            }

            set
            {
                veiculo = value;
                bsVeiculo.DataSource = veiculo;
                if (veiculo.Foto != null)
                {
                    pbFoto.Image = Util.byteArrayToImage(veiculo.Foto);
                }

                if (veiculo.Proprietario != null)
                {
                    txtProprietario.Tag = veiculo.Proprietario.Id;
                    txtProprietario.Text = veiculo.Proprietario.Nome;
                }
            }
        }
        public CadVeiculo()
        {
            InitializeComponent();
            Veiculo = new Veiculo();
        }

        public CadVeiculo(Veiculo veiculo)
        {
            InitializeComponent();
            Veiculo = veiculo;
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            var foto = PortariaWebCam.ObterImagem();
            if (foto != null)
            {
                pbFoto.Image = foto;
                veiculo.Foto = Util.imageToByteArray(foto);
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
            var veiculoBus = new VeiculoBus(SessaoAtual.Sessao);
            veiculoBus.InserirOuAtualizar(Veiculo);

            Close();
        }

        private void EditarProprietario()
        {
            Veiculo.Proprietario = SelecionaPessoa.Selecionar(Veiculo.Proprietario);

            if (veiculo.Proprietario != null)
            {
                txtProprietario.Tag = veiculo.Proprietario.Id;
                txtProprietario.Text = veiculo.Proprietario.Nome;
            }
            else
            {
                txtProprietario.Tag = null;
                txtProprietario.Text = string.Empty;
            }
        }

        private void btnEditarProprietario_Click(object sender, EventArgs e)
        {
            EditarProprietario();
        }
    }
}
