using Portaria.Framework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portaria.Webcam
{
    public partial class PortariaWebCam : FormBase
    {
        private DirectShowLib.Capture _camera;

        private Image imagem = null;

        public PortariaWebCam()
        {
            InitializeComponent();

            InicializaWebCam();
        }

        private void InicializaWebCam()
        {
            // Considerar a primeira câmera que for encontrada no sistema
            const int VIDEODEVICE = 0;
            // Resolucao de 640x480, 24 bits por pixel. A sua câmera tem que suportar essa resolução, senão, altere para uma resolução suportada.
            const int VIDEOWIDTH = 320;
            const int VIDEOHEIGHT = 240;
            const int VIDEOBITSPERPIXEL = 24;
 
            _camera = new DirectShowLib.Capture(VIDEODEVICE, VIDEOWIDTH, VIDEOHEIGHT, VIDEOBITSPERPIXEL, pbWebcam);

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            imagem = null;

            Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            CapturarImagem();

            Close();
        }

        private void CapturarImagem()
        {
            var bitmap = new Bitmap(pbWebcam.Width, pbWebcam.Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                var webCamPoint = pbWebcam.PointToScreen(new Point(0, 0));
                graphics.CopyFromScreen(webCamPoint.X, webCamPoint.Y, 0, 0, bitmap.Size);
            }

            imagem = bitmap;
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            EscolherExistente();
        }

        private void EscolherExistente()
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagem = new Bitmap(ofd.FileName);

                    Close();
                }
            }
        }

        public static Image ObterImagem()
        {
            using (var frm = new PortariaWebCam())
            {
                frm.ShowDialog();
                return frm.imagem;
            }
        }

        private void PortariaWebCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            _camera.Dispose();
        }
    }
}
