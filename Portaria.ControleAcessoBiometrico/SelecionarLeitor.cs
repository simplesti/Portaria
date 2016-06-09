using DPUruNet;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Portaria.ControleAcessoBiometrico
{
    public partial class SelecionarLeitor : Form
    {
        private ReaderCollection _readers;
        
        public Capturador Sender { get; set; }   
        
        private void AtualizarLista()
        {
            cboLeitores.Text = string.Empty;
            cboLeitores.Items.Clear();
            cboLeitores.SelectedIndex = -1;

            try
            {
                _readers = ReaderCollection.GetReaders();

                foreach (Reader Reader in _readers)
                {
                    cboLeitores.Items.Add(Reader.Description.SerialNumber);
                }

                if (cboLeitores.Items.Count > 0)
                {
                    cboLeitores.SelectedIndex = 0;
                    btnSelecionar.Enabled = true;
                }
                else
                {
                    btnSelecionar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                //message box:
                String text = ex.Message;
                text += "\r\n\r\nPlease check if DigitalPersona service has been started";
                String caption = "Cannot access readers";
                MessageBox.Show(text, caption);
            }
        }

        public SelecionarLeitor()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (Sender.CurrentReader != null)
            {
                Sender.CurrentReader.Dispose();
                Sender.CurrentReader = null;
            }
            Sender.CurrentReader = _readers[cboLeitores.SelectedIndex];
            this.Close();
        }

        public void SetaLeitor(string value)
        {
            Sender.CurrentReader = _readers.FirstOrDefault(r => r.Description.SerialNumber.Equals(value));
        }
    }
}
