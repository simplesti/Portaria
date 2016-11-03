using DPUruNet;
using Portaria.Core;
using Portaria.Desktop.Framework.CaixaMensagem;
using System;
using System.Diagnostics;

namespace Portaria.Biometria
{
    public partial class PortariaBiometriaVerificar : PortariaBiometriaFormBase
    {

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

            lblVerificarBiometria.Text = lblVerificarBiometria.Text.Replace("<pessoa>", this.entidade.Nome);
        }

        public static bool Verificar(IBiometria entidade)
        {
            if (Debugger.IsAttached)
            {
                return true;
            }

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
            CancelCaptureAndCloseReader(OnCaptured);
            resultado = false;
            Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            CancelCaptureAndCloseReader(OnCaptured);

            Close();
        }

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
                    SetPrompt("Não foi possível verificar a biometria, tente novamente.");
                    return;
                }
                
                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    Reset = true;
                    throw new Exception(resultConversion.ResultCode.ToString());
                }

                var biometriaOriginal = Fmd.DeserializeXml(entidade.Biometria);

                CompareResult compareResult = Comparison.Compare(biometriaOriginal, 0, resultConversion.Data, 0);
                if (compareResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    Reset = true;
                    throw new Exception(compareResult.ResultCode.ToString());
                }

                if (compareResult.Score == 0)
                {
                    SetPrompt("Biometria verificada com sucesso!");
                    resultado = true;
                    HabilitaOK();

                    CancelCaptureAndCloseReader(OnCaptured);
                }
                else
                {
                    Reset = true;
                    SetPrompt("Não foi possível verificar a biometria, tente novamente.");
                    return;
                }
            }
            catch (Exception ex)
            {
                SetPrompt("Erro:  " + ex.Message);
            }
        }

        private void HabilitaOK()
        {
            Invoke(new Function(delegate ()
            {
                btnOK.Enabled = true;
            }));
        }

        private void PortariaBiometriaVerificar_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
