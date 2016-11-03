using Portaria.Business;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Portaria.Inicio
{
    public partial class TabInicio : PortariaTabBase
    {
        public event EventHandler VisualizarUnidades;

        public event EventHandler VisualizarReservas;

        public event EventHandler VisualizarLivroNegro;

        public event EventHandler VisualizarServicos;

        public event EventHandler VisualizarVisitantes;

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Porteiro };
            }
        }

        public TabInicio()
        {
            InitializeComponent();
        }

        private void bolhaUnidades_Click(object sender, System.EventArgs e)
        {
            VisualizarUnidades(sender, e);
        }

        private void bolhaReserva_Click(object sender, EventArgs e)
        {
            VisualizarReservas(sender, e);
        }

        private void bolhaLivroNegro_Click(object sender, EventArgs e)
        {
            VisualizarLivroNegro(sender, e);
        }

        private void bolhaServicos_Click(object sender, EventArgs e)
        {
            VisualizarServicos(sender, e);
        }

        private void bolhaVisitantes_Click(object sender, EventArgs e)
        {
            VisualizarVisitantes(sender, e);
        }

        private void TabInicio_Load(object sender, EventArgs e)
        {
            CarregarMural();
        }

        private void CarregarMural()
        {
            if (!DesignMode)
            {
                var registroMuralBus = new RegistroMuralBus(SessaoAtual.Sessao);
                bsMural.DataSource = registroMuralBus.Recentes(50);
            }
        }

        private void botaoAddMural_Click(object sender, EventArgs e)
        {
            AdicionarMensagemMural();
            CarregarMural();
        }

        private void AdicionarMensagemMural()
        {
            var registroMural = new RegistroMural()
            {
                Mensagem = txtMural.Text
            };

            var registroMuralBus = new RegistroMuralBus(SessaoAtual.Sessao);
            registroMuralBus.InserirOuAtualizar(registroMural);

            txtMural.Text = string.Empty;
        }

        private void txtMural_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                AdicionarMensagemMural();
            }
        }
    }
}
