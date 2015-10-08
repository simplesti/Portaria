using Portaria.Business;
using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Desktop.Framework.Forms;
using Portaria.Desktop.Framework.Locais;
using System.Collections.Generic;
using System.Linq;

namespace Portaria.Locais
{
    public partial class TabReservarLocais : PortariaTabBase
    {
        public TabReservarLocais()
        {
            InitializeComponent();

            CarregarLocais();
        }

        private void CarregarLocais()
        {
            if (!DesignMode)
            {
                var localBus = new LocalBus(SessaoAtual.Sessao);
                var todosLocais = localBus.Todos().ToList();

                foreach (var local in todosLocais)
                {
                    var item = new LocalItem(local);
                    item.VisualizarLocalClick += item_VisualizarLocalClick;
                    flpLocais.Controls.Add(item);
                }
            }
        }

        void item_VisualizarLocalClick(object sender, LocalEventArgs e)
        {
            using (var frm = new VisReservas(e.Local))
            {
                frm.ShowDialog();
            }

            Carregar();
        }

        public override void Carregar(params Core.Model.IEntidade[] entidades)
        {
            base.Carregar();

            if (entidades.Any())
            {
                CarregarReservas(entidades.Select(e => e.Id));
            }
            else
            {
                CarregarReservasProximas();
            }
        }

        private void CarregarReservas(IEnumerable<int> ids)
        {
            var reservaBus = new ReservaBus(SessaoAtual.Sessao);

            var query = reservaBus.Todos().AsQueryable();
            query = query.Where(e => ids.Contains(e.Id));

            dgvReservas.DataSource = query.ToList();
        }

        private void CarregarReservasProximas()
        {
            var reservaBus = new ReservaBus(SessaoAtual.Sessao);
            var query = reservaBus.Todos();

            query = query.OrderByDescending(r => r.DataHoraInicio)
                .Take(10);

            dgvReservas.DataSource = query.ToList();
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador, TipoUsuario.SomenteLeitura };
            }
        }
    }
}
