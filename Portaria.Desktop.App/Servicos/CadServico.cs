using Portaria.Business;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;

namespace Portaria.Servicos
{
    public partial class CadServico : MaterialPortariaFormWindow
    {
        private ContatoServico contatoServico;

        public ContatoServico ContatoServico
        {
            get
            {
                return contatoServico;
            }

            set
            {
                contatoServico = value;
                bsContatoServico.DataSource = contatoServico;
            }
        }

        public CadServico()
        {
            InitializeComponent();

            CarregarTipos();

            ContatoServico = new ContatoServico();
        }

        public CadServico(ContatoServico contatoServico)
        {
            InitializeComponent();

            CarregarTipos();

            ContatoServico = contatoServico;
        }

        private void CarregarTipos()
        {
            cboTipoServico.DataSource = new[]
            {
                TipoContatoServico.Outro,
                TipoContatoServico.Eletricista,
                TipoContatoServico.Hidraulica,
                TipoContatoServico.Jardim,
                TipoContatoServico.Pedreiro,
                TipoContatoServico.TvTelefoniaInternet
            };
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var contatoServicoBus = new ContatoServicoBus(SessaoAtual.Sessao);
            contatoServicoBus.InserirOuAtualizar(ContatoServico);

            Close();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (ContatoServico.Id > 0)
            {
                if (CaixaMensagem.Mostrar("Deseja excluir o serviço cadastrado?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
                {
                    var contatoServicoBus = new ContatoServicoBus(SessaoAtual.Sessao);
                    contatoServicoBus.Remover(ContatoServico);

                    Close();
                }
            }
        }
    }
}
