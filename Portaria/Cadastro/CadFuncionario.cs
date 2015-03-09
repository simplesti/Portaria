using Portaria.Business;
using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework;
using Portaria.Framework.Forms;
using Portaria.Webcam;
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

            AplicarPermissoes();
        }

        private void AplicarPermissoes()
        {
            if (SessaoBus.Sessao().UsuarioLogado.Tipo != Core.TipoUsuario.Administrador)
            {
                txtDescricao.ReadOnly = true;
                txtDocumento.ReadOnly = true;
                txtFone.ReadOnly = true;
                txtFrequencia.ReadOnly = true;
                txtNome.ReadOnly = true;

                botaoSalvar.Visible = false;

                chkAutorizadoSemPresenca.Enabled = false;

                dtEntrada.Enabled = false;
                dtSaida.Enabled = false;
            }
        }

        public CadFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            Funcionario = funcionario;

            AplicarPermissoes();
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
            if (SessaoBus.Sessao().UsuarioLogado.Tipo == Core.TipoUsuario.Administrador)
            {
                var foto = PortariaWebCam.ObterImagem();
                if (foto != null)
                {
                    pbFoto.Image = foto;
                    funcionario.Foto = Util.imageToByteArray(foto);
                }
            }
        }
    }
}
