using System;
using System.Configuration;
using System.Windows.Forms;

namespace Portaria.ControleAcessoBiometrico
{
    public partial class ConfigurarClientRPi : Form
    {
        public ConfigurarClientRPi()
        {
            InitializeComponent();

            Carregar();
        }

        private void Carregar()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settingsEndPoint = config.AppSettings.Settings["ApiEndPoint"];
            var settingsTempoLiberacao = config.AppSettings.Settings["TempoLiberacao"];

            if (settingsEndPoint != null)
            {
                txtEndereco.Text = settingsEndPoint.Value;
            }

            if (settingsTempoLiberacao != null)
            {
                mtbTempo.Text = settingsTempoLiberacao.Value;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }

        private void Salvar()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("ApiEndPoint");
            config.AppSettings.Settings.Add("ApiEndPoint", txtEndereco.Text);

            config.AppSettings.Settings.Remove("TempoLiberacao");
            config.AppSettings.Settings.Add("TempoLiberacao", mtbTempo.Text);

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
