using Portaria.Biometria;
using Portaria.Business;
using Portaria.Cadastro;
using Portaria.Core.Model;
using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.Forms;
using System;

namespace Portaria.Locais
{
    public partial class CadReserva : FormBaseWindow
    {
        private bool permitirEscolherFimReserva = false;
        private int diasFimReserva = 0;
        private TimeSpan horaFimReserva = TimeSpan.Zero;
                
        private Reserva reserva;

        public Reserva Reserva
        {
            get
            {
                reserva.DataHoraFim = dtFim.Value;
                return reserva;
            }

            set
            {
                reserva = value;
                txtLocal.Text = reserva.Local.Nome;

                if (reserva.Pessoa != null)
                {
                    txtSolicitante.Text = reserva.Pessoa.Nome;
                }

                bsReserva.DataSource = reserva;
            }
        }

        public CadReserva(Local local)
        {
            InitializeComponent();

            CarregarConfigs();

            Reserva = new Reserva() { Local = local };
            dtInicio.Value = DateTime.Now;
        }

        private void CarregarConfigs()
        {
            if (!Util.IsInDesignMode())
            {
                var configuracaoBus = new ConfiguracaoBus(SessaoAtual.Sessao);

                bool.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.PermitirEscolherFimReserva), out permitirEscolherFimReserva);
                int.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.DuracaoReservaDias), out diasFimReserva);
                TimeSpan.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.DuracaoReservaHora), out horaFimReserva);

                dtFim.Enabled = permitirEscolherFimReserva;
            }
        }

        public CadReserva(Reserva reserva)
        {
            InitializeComponent();

            CarregarConfigs();

            Reserva = reserva;

            AplicarPermissoes();
        }

        private void AplicarPermissoes()
        {
            if (SessaoAtual.Sessao.UsuarioLogado.Tipo != Core.TipoUsuario.Administrador)
            {
                botaoEditarSolicitante.Visible = false;
                dtFim.Enabled = false;
                dtInicio.Enabled = false;

                botaoSalvar.Visible = false;
            }
        }

        private void botaoEditarSolicitante_Click(object sender, System.EventArgs e)
        {
            EditarSolicitante();
        }

        private void EditarSolicitante()
        {
            Reserva.Pessoa = SelecionaPessoa.Selecionar();

            if (Reserva.Pessoa != null)
            {
                txtSolicitante.Text = Reserva.Pessoa.Nome;
            }
            else
            {
                txtSolicitante.Text = string.Empty;
            }
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
            if (PortariaBiometriaVerificar.Verificar(Reserva.Pessoa))
            {
                var reservaBus = new ReservaBus(SessaoAtual.Sessao);
                reservaBus.InserirOuAtualizar(Reserva);

                Close();
            }
        }

        private void botaoPesquisarUnidade_Click(object sender, EventArgs e)
        {
            Reserva.Unidade = SelecionaEntidade.SelecionarUnidade();
            if (Reserva.Unidade != null)
            {
                txtUnidade.Text = Reserva.Unidade.Bloco + " - " + Reserva.Unidade.Numero.ToString();
            }
            else
            {
                txtUnidade.Text = string.Empty;
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            if (!permitirEscolherFimReserva)
            {
                dtFim.Value = dtInicio.Value.Date.AddDays(diasFimReserva).AddHours(horaFimReserva.Hours).AddMinutes(horaFimReserva.Minutes);
            }
        }
    }
}
