using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework;
using Portaria.Framework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Cadastro
{
    public partial class CadVeiculo : FormBaseWindow
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
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pbFoto.Image = new Bitmap(ofd.FileName);
                    veiculo.Foto = Util.imageToByteArray(pbFoto.Image);
                }
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
            var veiculoBus = new VeiculoBus();
            veiculoBus.InserirOuAtualizar(Veiculo);

            Close();
        }

        private void EditarProprietario()
        {
            var veiculoBus = new VeiculoBus();
            var pessoaBus = new PessoaBus();

            if (Veiculo.Id == 0)
            {

                veiculoBus.InserirOuAtualizar(Veiculo);
            }

            Pessoa p = null;

            if (Veiculo.Proprietario != null)
                p = pessoaBus.BuscaPorId(Veiculo.Proprietario.Id);

            if (p == null)
            {
                p = new Pessoa();
            }

            using (var frm = new CadPessoa(p))
            {
                frm.ShowDialog();
            }

            var v = veiculoBus.BuscaPorId(Veiculo.Id);
            v.Proprietario = p;
            veiculoBus.InserirOuAtualizar(v);

            Veiculo = veiculoBus.BuscaPorId(v.Id);
        }

        private void btnEditarProprietario_Click(object sender, EventArgs e)
        {
            EditarProprietario();
        }
    }
}
