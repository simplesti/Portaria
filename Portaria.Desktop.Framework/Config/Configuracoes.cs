using Portaria.Business;
using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Portaria
{
    public partial class Configuracoes : FormBaseWindow
    {
        public Configuracoes()
        {
            InitializeComponent();

            CarregarValores();
        }

        private void CarregarValores()
        {
            if (!Util.IsInDesignMode())
            {
                var configuracaoBus = new ConfiguracaoBus(SessaoAtual.Sessao);

                var escolherFimReserva = false;
                bool.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.PermitirEscolherFimReserva), out escolherFimReserva);
                chkEscolherFimReserva.Checked = escolherFimReserva;
                mtbDiasDuracao.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.DuracaoReservaDias);
                mtbHorasDuracao.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.DuracaoReservaHora);

                var semRestricaoAntecedencia = false;
                bool.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.SemRestricaoAntecedencia), out semRestricaoAntecedencia);
                chkSemRestricaoAntecedencia.Checked = semRestricaoAntecedencia;
                mtbPrazoAntecedenciaReserva.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.PrazoAntecedenciaReservaDias);

                txtEMailRemetente.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.UsuarioSMTP);
                txtEMailResponsavel.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.EmailResponsavel);
                txtPortaSMTP.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.PortaSMTP);
                txtSenhaRemetente.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.SenhaSMTP);
                txtServidorSMTP.Text = configuracaoBus.BuscarValor(Core.TipoConfiguracao.ServidorSMTP);

                var segura = false;
                bool.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.ConexaoSeguraSMTP), out segura);
                chkConexaoSegura.Checked = segura;
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkEscolherFimReserva_CheckedChanged(object sender, EventArgs e)
        {
            mtbDiasDuracao.Enabled = !chkEscolherFimReserva.Checked;
            mtbHorasDuracao.Enabled = !chkEscolherFimReserva.Checked;
        }

        private void chkSemRestricaoAntecedencia_CheckedChanged(object sender, EventArgs e)
        {
            mtbPrazoAntecedenciaReserva.Enabled = !chkSemRestricaoAntecedencia.Checked;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

            Close();
        }

        private void Salvar()
        {
            var configuracaoBus = new ConfiguracaoBus(SessaoAtual.Sessao);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.DuracaoReservaDias, mtbDiasDuracao.Text);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.DuracaoReservaHora, mtbHorasDuracao.Text);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.PermitirEscolherFimReserva, chkEscolherFimReserva.Checked.ToString());

            configuracaoBus.SetarValor(Core.TipoConfiguracao.PrazoAntecedenciaReservaDias, mtbPrazoAntecedenciaReserva.Text);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.SemRestricaoAntecedencia, chkSemRestricaoAntecedencia.Checked.ToString());

            configuracaoBus.SetarValor(Core.TipoConfiguracao.UsuarioSMTP, txtEMailRemetente.Text);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.EmailResponsavel, txtEMailResponsavel.Text);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.PortaSMTP, txtPortaSMTP.Text);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.SenhaSMTP, txtSenhaRemetente.Text);
            configuracaoBus.SetarValor(Core.TipoConfiguracao.ServidorSMTP, txtServidorSMTP.Text);            
            configuracaoBus.SetarValor(Core.TipoConfiguracao.ConexaoSeguraSMTP, chkConexaoSegura.Checked.ToString());
        }

        private void botaoPesquisarSMTP_Click(object sender, EventArgs e)
        {
            if (txtEMailRemetente.Text.Contains('@'))
            {
                BuscarServidorSMTP();
            }
        }

        private void BuscarServidorSMTP()
        {
            var dominio = txtEMailRemetente.Text.Split('@')[1];

            var reader = new XmlTextReader(Application.StartupPath + @"\ServidoresSMTP.xml");
            while (reader.Read())
            {
                var domXml = reader.GetAttribute("dominio");
                if (domXml != null && domXml.ToUpper() == dominio.ToUpper())
                {
                    txtServidorSMTP.Text = reader.GetAttribute("servidor");
                    txtPortaSMTP.Text = reader.GetAttribute("porta");
                    chkConexaoSegura.Checked = bool.Parse(reader.GetAttribute("segura"));
                }
            }
        }
    }
}
