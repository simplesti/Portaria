using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework.Blocos;
using Portaria.Desktop.Framework.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Portaria
{
    public partial class TabVisualizarBlocos : PortariaTabBase
    {
        public TabVisualizarBlocos()
        {
            InitializeComponent();
        }

        private void CarregarTodosBlocos()
        {
            var blocoBus = new BlocoBus(SessaoAtual.Sessao);
            var blocos = blocoBus.Todos();

            PopulaBlocos(blocos);
        }

        public override void Carregar(params IEntidade[] entidades)
        {
            base.Carregar();
            CarregarTodosBlocos();
        }

        private void PopulaBlocos(IEnumerable<Bloco> blocos)
        {
            flpBlocos.Controls.Clear();
            foreach (var bloco in blocos)
            {
                var b = new BlocoItem(bloco);
                b.VisualizarBlocoClick += b_VisualizarBlocoClick;
                flpBlocos.Controls.Add(b);
            }
        }

        void b_VisualizarBlocoClick(object sender, BlocoEventArgs e)
        {
            VisualizarUnidades(e.Bloco);
        }

        private void VisualizarUnidades(Bloco bloco)
        {
            if (TabVisualizar != null)
            {
                var unidadeBus = new UnidadeBus(SessaoAtual.Sessao);

                var unidades = unidadeBus.Todos().Where(e => e.Bloco.Id == bloco.Id);

                TabVisualizar.Carregar(unidades.ToArray());
            }
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Porteiro };
            }
        }
    }
}
