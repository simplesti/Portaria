using Portaria.ControleAcessoBiometrico.Properties;
using Portaria.RPi.Api;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Portaria.ControleAcessoBiometrico
{
    public class CABAppContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        private RPiControleAcesso controleAcesso;

        private Capturador capturador;

        private Timer timerAtualizacaoCache;

        public CABAppContext()
        {
            capturador = new Capturador();

            InicializaControleAcesso();

            trayIcon = new NotifyIcon()
            {
                Icon = Resources.icone,
                Visible = true,
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Sair", Sair),
                new MenuItem("Selecionar Leitor", capturador.Selecionar),
                new MenuItem("Configurar RaspberryPI", ConfigurarRPi),
                new MenuItem("Configurar Tempo de atualização do cache", ConfigurarTempoCache)})
            };

            capturador.AcessoPermitido += Capturador_AcessoPermitido;

            RepositorioBiometria.AtualizarCache();

            InicializarTimerCache();
        }

        private void InicializarTimerCache()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settingsTempoCache = config.AppSettings.Settings["TempoAtualizacaoCache"];
            if (settingsTempoCache == null)
            {
                ConfigurarTempoCache(this, new EventArgs());
            }
            else
            {
                SetaTimerCache(int.Parse(settingsTempoCache.Value));
            }
        }

        private void SetaTimerCache(int tempoEmMinutos)
        {
            if (timerAtualizacaoCache != null)
            {
                timerAtualizacaoCache.Dispose();
            }

            timerAtualizacaoCache = new Timer();
            timerAtualizacaoCache.Interval = (tempoEmMinutos * 60) * 1000;
            timerAtualizacaoCache.Tick += TimerAtualizacaoCache_Tick;
            timerAtualizacaoCache.Start();
        }

        private void TimerAtualizacaoCache_Tick(object sender, EventArgs e)
        {
            RepositorioBiometria.AtualizarCache();
        }

        private void ConfigurarTempoCache(object sender, EventArgs e)
        {
            using (var frm = new ConfigurarTimerCache())
            {
                frm.ShowDialog();
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settingsTempoCache = config.AppSettings.Settings["TempoAtualizacaoCache"];

            if (settingsTempoCache == null)
            {
                throw new Exception("Você precisa ajustar o tempo de atualização do cache de pessoas.");
            }

            SetaTimerCache(int.Parse(settingsTempoCache.Value));
        }

        private void ConfigurarRPi(object sender, EventArgs e)
        {
            using (var frm = new ConfigurarClientRPi())
            {
                frm.ShowDialog();
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settingsEndPoint = config.AppSettings.Settings["ApiEndPoint"];
            var settingsTempoLiberacao = config.AppSettings.Settings["TempoLiberacao"];

            if (settingsEndPoint == null || settingsTempoLiberacao == null)
            {
                throw new Exception("Você precisa ajustar os parametros do RaspberryPi.");
            }

            controleAcesso = new RPiControleAcesso(settingsEndPoint.Value, int.Parse(settingsTempoLiberacao.Value));
        }

        private void InicializaControleAcesso()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settingsEndPoint = config.AppSettings.Settings["ApiEndPoint"];
            var settingsTempoLiberacao = config.AppSettings.Settings["TempoLiberacao"];

            if (settingsEndPoint == null || settingsTempoLiberacao == null)
            {
                ConfigurarRPi(this, new EventArgs());
            }
            else
            {
                controleAcesso = new RPiControleAcesso(settingsEndPoint.Value, int.Parse(settingsTempoLiberacao.Value));
            }
        }

        private void Capturador_AcessoPermitido(object sender, AcessoLiberadoEventArgs e)
        {
            controleAcesso.LiberarAcesso();
        }

        private void Sair(object sender, EventArgs e)
        {
            capturador.CancelCaptureAndCloseReader(capturador.OnCaptured);

            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
