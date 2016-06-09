using DPUruNet;
using System;

namespace Portaria.Biometria
{
    public partial class PortariaBiometriaCapturar : PortariaBiometriaFormBase
    {
        private string fmd = null;

        delegate void Function();

        public override void SetPrompt(string prompt)
        {
            Invoke(new Function(delegate ()
            {
                Prompt.Text = prompt;
            }));
        }

        public override void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                Picture.Image = CreateBitmap(captureResult.Data.Views[0].RawImage, captureResult.Data.Views[0].Width, captureResult.Data.Views[0].Height);

                if (!CheckCaptureResult(captureResult))
                {
                    Reset = true;
                    SetPrompt("Não foi possível capturar a biometria, tente novamente.");
                    return;
                }

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    Reset = true;
                    throw new Exception(resultConversion.ResultCode.ToString());
                }
                
                SetPrompt("Biometria capturada com sucesso!");

                fmd = Fmd.SerializeXml(resultConversion.Data);                

                CancelCaptureAndCloseReader(OnCaptured);

                HabilitaOK();
            }
            catch (Exception ex)
            {
                SetPrompt("Erro:  " + ex.Message);
            }
        }

        protected void HabilitaOK()
        {
            Invoke(new Function(delegate ()
            {
                botaoOK.Enabled = true;
            }));
        }

        public PortariaBiometriaCapturar()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            CancelCaptureAndCloseReader(OnCaptured);

            fmd = null;
            Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            CancelCaptureAndCloseReader(OnCaptured);

            Close();
        }

        public static string Capturar()
        {
            using (var frm = new PortariaBiometriaCapturar())
            {
                frm.ShowDialog();

                return frm.fmd;
            }
        }

        private void PortariaBiometriaCapturar_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
