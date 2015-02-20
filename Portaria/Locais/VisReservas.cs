using Portaria.Business;
using Portaria.Core.Model.Cadastro;
using Portaria.Framework;
using Portaria.Framework.CaixaMensagem;
using Portaria.Framework.Forms;
using System;
using System.Linq;

namespace Portaria.Locais
{
    public partial class VisReservas : FormBaseWindow
    {
        private Local local;

        public Local Local
        {
            get
            {
                return local;
            }

            set
            {
                local = value;

                txtLocal.Text = local.Nome;
                if (local.Foto != null)
                {
                    pbFoto.Image = Util.byteArrayToImage(local.Foto);
                }
            }
        }

        public VisReservas()
        {
            InitializeComponent();
        }

        public VisReservas(Local local)
        {
            InitializeComponent();

            Local = local;

            CarregarUltimasReservas();
        }

        private void CarregarUltimasReservas()
        {
            var reservaBus = new ReservaBus();
            var query = reservaBus.Todos().AsQueryable();
            query = query.Where(r => r.Local.Id == Local.Id)
                .Take(30);

            bsReservas.DataSource = query.ToList();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            Close();
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarReserva();
        }

        private void AdicionarReserva()
        {
            using (var frm = new CadReserva())
            {
                frm.ShowDialog();
            }

            CarregarUltimasReservas();
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 1)
            {
                RemoverReserva();
            }
        }

        private void RemoverReserva()
        {
            var id = int.Parse(dgvReservas.SelectedRows[0].Cells[0].Value.ToString());
            var reservaBus = new ReservaBus();
            var r = reservaBus.BuscaPorId(id);

            if (CaixaMensagem.Mostrar("Deseja remover a reserva da data  " + r.DataHoraInicio.ToString("dd/MM/yyyy HH:mm:ss") + " ?", TipoCaixaMensagem.OKCancelar) == System.Windows.Forms.DialogResult.OK)
            {
                reservaBus.Remover(r);

                CarregarUltimasReservas();
            }
        }

        private void dgvReservas_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 1)
            {
                EditarReserva();
            }
        }

        private void EditarReserva()
        {
            var id = int.Parse(dgvReservas.SelectedRows[0].Cells[0].Value.ToString());
            var reservaBus = new ReservaBus();
            var r = reservaBus.BuscaPorId(id);

            using (var frm = new CadReserva(r))
            {
                frm.ShowDialog();
            }

            dgvReservas.Refresh();
        }
    }
}
