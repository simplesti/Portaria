using DPUruNet;
using System;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Portaria.ControleAcessoBiometrico
{
    public class Capturador
    {
        public event EventHandler<AcessoLiberadoEventArgs> AcessoPermitido;
        public bool Reset
        {
            get { return reset; }
            set { reset = value; }
        }
        private bool reset;

        public Reader CurrentReader { get; set; }

        private const int DPFJ_PROBABILITY_ONE = 0x7fffffff;

        public Capturador()
        {
            SetarLeitor();
            InicializarCaptura();
        }


        private void SetarLeitor()
        {
            if (CurrentReader == null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settingsLeitor = config.AppSettings.Settings["SerialLeitorDP"];
                if (settingsLeitor == null)
                {
                    Selecionar(this, new EventArgs());
                }
                else
                {
                    using (var frm = new SelecionarLeitor())
                    {
                        frm.Sender = this;
                        frm.SetaLeitor(settingsLeitor.Value);
                    }
                }

            }
        }

        private void InicializarCaptura()
        {
            if (!OpenReader())
            {
                throw new Exception("Erro ao acessar o leitor");
            }

            if (!StartCaptureAsync(OnCaptured))
            {
                throw new Exception("Erro ao iniciar a captura.");
            }
        }

        public bool CaptureFingerAsync()
        {
            try
            {
                GetStatus();

                Constants.ResultCode captureResult = CurrentReader.CaptureAsync(Constants.Formats.Fid.ANSI, Constants.CaptureProcessing.DP_IMG_PROC_DEFAULT, CurrentReader.Capabilities.Resolutions[0]);
                if (captureResult != Constants.ResultCode.DP_SUCCESS)
                {
                    reset = true;
                    throw new Exception("" + captureResult);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:  " + ex.Message);
                return false;
            }
        }

        public bool CheckCaptureResult(CaptureResult captureResult)
        {
            if (captureResult.Data == null)
            {
                if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    reset = true;
                    throw new Exception(captureResult.ResultCode.ToString());
                }

                if ((captureResult.Quality != Constants.CaptureQuality.DP_QUALITY_CANCELED))
                {
                    throw new Exception("Qualidade - " + captureResult.Quality);
                }
                return false;
            }
            return true;
        }

        public void GetStatus()
        {
            Constants.ResultCode result = CurrentReader.GetStatus();

            if ((result != Constants.ResultCode.DP_SUCCESS))
            {
                if (CurrentReader != null)
                {
                    CurrentReader.Dispose();
                    CurrentReader = null;
                }
                throw new Exception("" + result);
            }

            if ((CurrentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_BUSY))
            {
                Thread.Sleep(50);
            }
            else if ((CurrentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_NEED_CALIBRATION))
            {
                CurrentReader.Calibrate();
            }
            else if ((CurrentReader.Status.Status != Constants.ReaderStatuses.DP_STATUS_READY))
            {
                throw new Exception("Estado do leitor - " + CurrentReader.Status.Status);
            }
        }

        public void CancelCaptureAndCloseReader(Reader.CaptureCallback OnCaptured)
        {
            if (CurrentReader != null)
            {
                CurrentReader.CancelCapture();

                CurrentReader.Dispose();

                if (reset)
                {
                    CurrentReader = null;
                }
            }
        }

        public bool StartCaptureAsync(Reader.CaptureCallback OnCaptured)
        {
            CurrentReader.On_Captured += new Reader.CaptureCallback(OnCaptured);

            if (!CaptureFingerAsync())
            {
                return false;
            }

            return true;
        }

        public bool OpenReader()
        {
            reset = false;
            Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;

            result = CurrentReader.Open(Constants.CapturePriority.DP_PRIORITY_EXCLUSIVE);

            if (result != Constants.ResultCode.DP_SUCCESS)
            {
                MessageBox.Show("Erro:  " + result);
                reset = true;
                return false;
            }

            return true;
        }

        public void Selecionar(object sender, EventArgs e)
        {
            using (var frm = new SelecionarLeitor())
            {
                frm.Sender = this;
                frm.ShowDialog();

                if (CurrentReader != null)
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings.Remove("SerialLeitorDP");
                    config.AppSettings.Settings.Add("SerialLeitorDP", CurrentReader.Description.SerialNumber);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
        }

        public void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                if (!CheckCaptureResult(captureResult))
                {
                    Reset = true;
                    return;
                }

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    Reset = true;
                    throw new Exception(resultConversion.ResultCode.ToString());
                }

                int thresholdScore = DPFJ_PROBABILITY_ONE * 1 / 100000;

                var fmds = RepositorioBiometria.BiometriasAutorizadas.Select(s => s.Fmd);

                IdentifyResult identifyResult = Comparison.Identify(resultConversion.Data, 0, fmds, thresholdScore, 2);
                if (identifyResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    Reset = true;
                    throw new Exception(identifyResult.ResultCode.ToString());
                }

                if (identifyResult.Indexes.Length > 0)
                {
                    AcessoPermitido(this, new AcessoLiberadoEventArgs(RepositorioBiometria.BiometriasAutorizadas.ElementAt(identifyResult.Indexes.FirstOrDefault().FirstOrDefault()
                        )));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:  " + ex.Message);
            }
        }
    }
}
