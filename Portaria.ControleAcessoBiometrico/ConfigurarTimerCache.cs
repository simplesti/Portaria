using System;
using System.Configuration;
using System.Windows.Forms;

namespace Portaria.ControleAcessoBiometrico
{
    public partial class ConfigurarTimerCache : Form
    {
        public ConfigurarTimerCache()
        {
            InitializeComponent();

            Carregar();
        }

        private void Carregar()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settingsTempoCache = config.AppSettings.Settings["TempoAtualizacaoCache"];

            if (settingsTempoCache != null)
            {
                mtbTempoCache.Text = settingsTempoCache.Value;
            }            
        }
        
        private void Salvar()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("TempoAtualizacaoCache");
            config.AppSettings.Settings.Add("TempoAtualizacaoCache", mtbTempoCache.Text);

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
