using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portaria.Business.Cadastro;
using Portaria.Framework.Unidades;
using Portaria.Framework.Forms;
using Portaria.Core;

namespace Portaria
{
    public partial class TabVisualizarUnidades : UserControl, IPortariaTab
    {
        public TabVisualizarUnidades()
        {
            InitializeComponent();
        }

        private void CarregarTodasUnidades()
        {
            var unidadeBus = new UnidadeBus();

            foreach (var unidade in unidadeBus.Todos())
            {
                var u = new UnidadeItem(unidade);
                u.VisualizarProprietarioClick += u_VisualizarProprietarioClick;
                u.VisualizarUnidadeClick += u_VisualizarUnidadeClick;
                flpUnidades.Controls.Add(u);
            }
        }

        void u_VisualizarUnidadeClick(object sender, UnidadeEventArgs e)
        {
            using (var frm = new CadUnidade(e.Unidade))
            {
                frm.ShowDialog();
            }
        }

        void u_VisualizarProprietarioClick(object sender, UnidadeEventArgs e)
        {
            if (e.Unidade.Proprietario != null)
            {
                using (var frm = new CadPessoa(e.Unidade.Proprietario))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void TabVisualizarUnidades_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarTodasUnidades();
            }
        }

        public ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador, TipoUsuario.SomenteLeitura };
            }
        }
    }
}
