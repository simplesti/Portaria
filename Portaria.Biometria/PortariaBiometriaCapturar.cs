using Portaria.Desktop.Framework;
using Portaria.Desktop.Framework.CaixaMensagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Biometria
{
    public partial class PortariaBiometriaCapturar : FormBase, DPFP.Capture.EventHandler
    {
        private DPFP.Processing.Enrollment Enroller;
        
        private DPFP.Capture.Capture Capturer;

        private byte[] bArray = null;

        delegate void Function();

        public PortariaBiometriaCapturar()
        {
            InitializeComponent();
        }
        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                Enroller = new DPFP.Processing.Enrollment();

                if (null != Capturer)
                    Capturer.EventHandler = this;
                else
                    SetPrompt("Não foi possível inicializar a operação de captura!");
            }
            catch
            {
                CaixaMensagem.Mostrar("Não foi possível inicializar a operação de captura!", TipoCaixaMensagem.SomenteOK);
            }
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));

            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            if (features != null) try
                {
                    Enroller.AddFeatures(features);	
                }
                finally
                {
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            MakeReport("Biometria capturada!");
                            bArray = Enroller.Template.Bytes;
                            HabilitaBotaoOK(true);
                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:
                            MakeReport("Biometria não capturada.");
                            Enroller.Clear();
                            Stop();
                            bArray = null;
                            HabilitaBotaoOK(false);
                            Start();
                            break;
                        case DPFP.Processing.Enrollment.Status.Insufficient:
                            MakeReport("Por favor, coloque novamente seu dedo no leitor.");
                            HabilitaBotaoOK(false);
                            break;
                    }
                }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Utilize o leitor para capturar sua biometria.");
                }
                catch
                {
                    SetPrompt("Não foi possível inicializar a captura.");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Não foi possível finalizar a captura.");
                }
            }
        }

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {

        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
            {
                return features;
            }
            else
            {
                return null;
            }
        }

        private void HabilitaBotaoOK(bool habilitado)
        {
            this.Invoke(new Function(delegate()
            {
                botaoOK.Enabled = habilitado;
            }));
        }

        protected void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate()
            {
                Prompt.Text = prompt;
            }));
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate()
            {
                StatusText.AppendText(message + "\r\n");
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate()
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);
            }));
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            bArray = null;
            Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static byte[] Capturar()
        {
            using (var frm = new PortariaBiometriaCapturar())
            {
                frm.ShowDialog();

                return frm.bArray;
            }
        }
    }
}
