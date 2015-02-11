using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portaria.Framework.Forms;
using Portaria.Core;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework.Blocos;
using Portaria.Business.Cadastro;
using Portaria.Core.Model;

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
            var blocoBus = new BlocoBus();
            var blocos = blocoBus.Todos();

            PopulaBlocos(blocos);
        }

        public override void Carregar(params IModel[] entidades)
        {
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
                var unidadeBus = new UnidadeBus();

                var unidades = unidadeBus.Todos().Where(e => e.Bloco.Id == bloco.Id);

                TabVisualizar.Carregar(unidades.ToArray());
            }
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
