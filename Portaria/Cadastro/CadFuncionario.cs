using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework;
using Portaria.Framework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.UnidadesBlocos
{
    public partial class CadFuncionario : FormBaseWindow
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
            }
        }

        public CadFuncionario()
        {
            InitializeComponent();
            Funcionario = new Funcionario();
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
            var funcionarioBus = new FuncionarioBus();
            funcionarioBus.InserirOuAtualizar(Funcionario);

            Close();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pbFoto.Image = new Bitmap(ofd.FileName);
                    funcionario.Foto = Util.imageToByteArray(pbFoto.Image);
                }
            }
        }
    }
}
