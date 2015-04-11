using Portaria.Core;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework;
using Portaria.Framework.CaixaMensagem;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Portaria.Biometria
{
    public partial class PortariaBiometriaVerificar : FormBase, DPFP.Capture.EventHandler
    {
        private DPFP.Template Template;

        private DPFP.Capture.Capture Capturer;

        delegate void Function();

        DPFP.Verification.Verification Verificator;

        bool resultado = false;

        IBiometria entidade = null;
        
        public PortariaBiometriaVerificar()
        {
            InitializeComponent();
        }

        public PortariaBiometriaVerificar(IBiometria entidade)
            : this()
        {
            this.entidade = entidade;

            GerarTemplate(entidade.Biometria);

            lblVerificarBiometria.Text = lblVerificarBiometria.Text.Replace("<pessoa>", this.entidade.Nome);
        }

        private void GerarTemplate(byte[] biometria)
        {
            using (MemoryStream ms = new MemoryStream(biometria))
            {
                Template = new DPFP.Template(ms);
            }
        }

        public static bool Verificar(IBiometria entidade)
        {
            if (entidade == null)
            {
                CaixaMensagem.Mostrar("Você precisa informar uma entidade.", TipoCaixaMensagem.SomenteOK);

                return false;
            }

            using (var frm = new PortariaBiometriaVerificar(entidade))
            {
                frm.ShowDialog();
                
                if (frm.resultado == false)
                {
                    CaixaMensagem.Mostrar("Você não confirmou a biometría de " + entidade.Nome + ".", TipoCaixaMensagem.SomenteOK);
                }

                return frm.resultado;
            }
        }

        private void botaoCancelar_Click(object sender, System.EventArgs e)
        {
            resultado = false;
            Close();
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                Verificator = new DPFP.Verification.Verification();

                if (null != Capturer)
                    Capturer.EventHandler = this;
                else
                    SetPrompt("Não foi possível inicializar a operação de verificação.");
            }
            catch
            {
                CaixaMensagem.Mostrar("Não foi possível inicializar a operação de verificação.", TipoCaixaMensagem.SomenteOK);
            }
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));

            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            if (features != null)
            {
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                Verificator.Verify(features, Template, ref result);

                Verficou(result.Verified);
            }
        }

        private void Verficou(bool resultado)
        {
            this.resultado = resultado;

            if(resultado)
            {
                MakeReport("A biometria foi verificada.");
            }
            else
            {
                MakeReport("A biometria não foi verificada.");
            }

            this.Invoke(new Function(delegate()
            {
                botaoOK.Enabled = resultado;
            }));
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Use o leitor para verificar a biometria.");
                }
                catch
                {
                    SetPrompt("Não foi possível inicializar a verificação.");
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
                    SetPrompt("Não foi possível finalizar a verificação.");
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
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("A biometria capturada está OK!");
            else
                MakeReport("A biometria capturada está ruim!");
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
                return features;
            else
                return null;
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

        private void botaoOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
