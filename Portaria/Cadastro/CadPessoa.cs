using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework;
using Portaria.Framework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria
{
    public partial class CadPessoa : FormBaseWindow
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
            }
        }

        public CadPessoa()
        {
            InitializeComponent();
            Pessoa = new Pessoa();
        }

        public CadPessoa(Pessoa pessoa)
        {
            InitializeComponent();
            Pessoa = pessoa;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pbFoto.Image = new Bitmap(ofd.FileName);
                    pessoa.Foto = Util.imageToByteArray(pbFoto.Image);
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
            var pessoaBus = new PessoaBus();
            pessoaBus.InserirOuAtualizar(Pessoa);

            Close();
        }
    }
}
