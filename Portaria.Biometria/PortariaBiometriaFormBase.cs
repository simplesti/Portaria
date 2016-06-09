using DPUruNet;
using Portaria.ControleAcessoBiometrico;
using Portaria.Desktop.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace Portaria.Biometria
{
    public partial class PortariaBiometriaFormBase : FormBase
    {
        public Reader CurrentReader { get; set; }

        public bool Reset
        {
            get { return reset; }
            set { reset = value; }
        }
        private bool reset;

        public PortariaBiometriaFormBase()
        {
            InitializeComponent();
        }

        public virtual void SetPrompt(string prompt)
        {
        }

        private void SelecionarLeitor()
        {
            using (var frm = new SelecionarLeitor())
            {
                frm.Sender = this;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settingsLeitor = config.AppSettings.Settings["SerialLeitorDP"];
                if (settingsLeitor != null)
                {
                    frm.SetaLeitor(settingsLeitor.Value);
                    return;
                }

                frm.ShowDialog();

                if (CurrentReader != null)
                {
                    config.AppSettings.Settings.Remove("SerialLeitorDP");
                    config.AppSettings.Settings.Add("SerialLeitorDP", CurrentReader.Description.SerialNumber);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
        }

        public virtual void Inicializar()
        {
            SelecionarLeitor();

            SetPrompt("Coloque o dedo no leitor.");

            if (!OpenReader())
            {
                Close();
            }

            if (!StartCaptureAsync(this.OnCaptured))
            {
                Close();
            }
        }

        public virtual bool OpenReader()
        {
            reset = false;
            Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;
            
            result = CurrentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

            if (result != Constants.ResultCode.DP_SUCCESS)
            {
                SetPrompt("Erro:  " + result);
                reset = true;
                return false;
            }

            return true;
        }

        public virtual bool StartCaptureAsync(Reader.CaptureCallback OnCaptured)
        {
            CurrentReader.On_Captured += new Reader.CaptureCallback(OnCaptured);
            
            if (!CaptureFingerAsync())
            {
                return false;
            }

            return true;
        }

        public virtual void CancelCaptureAndCloseReader(Reader.CaptureCallback OnCaptured)
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

        public virtual void GetStatus()
        {
            Constants.ResultCode result = CurrentReader.GetStatus();

            if ((result != Constants.ResultCode.DP_SUCCESS))
            {
                reset = true;
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

        public virtual bool CheckCaptureResult(CaptureResult captureResult)
        {
            if (captureResult.Data != null)
            {
                if (captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_GOOD)
                {
                    return true;
                }
            }

            return false;
        }

        public virtual bool CaptureFingerAsync()
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
                SetPrompt("Erro:  " + ex.Message);
                return false;
            }
        }

        public virtual Bitmap CreateBitmap(byte[] bytes, int width, int height)
        {
            byte[] rgbBytes = new byte[bytes.Length * 3];

            for (int i = 0; i <= bytes.Length - 1; i++)
            {
                rgbBytes[(i * 3)] = bytes[i];
                rgbBytes[(i * 3) + 1] = bytes[i];
                rgbBytes[(i * 3) + 2] = bytes[i];
            }
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            for (int i = 0; i <= bmp.Height - 1; i++)
            {
                IntPtr p = new IntPtr(data.Scan0.ToInt64() + data.Stride * i);
                System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3);
            }

            bmp.UnlockBits(data);

            return bmp;
        }

        public virtual void OnCaptured(CaptureResult captureResult)
        {
        }
    }
}
