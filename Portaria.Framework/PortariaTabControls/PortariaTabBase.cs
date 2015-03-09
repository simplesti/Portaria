using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Business;

namespace Portaria.Framework.Forms
{
    public partial class PortariaTabBase : UserControl, IPortariaTab
    {
        public PortariaTabBase()
        {
            InitializeComponent();
        }

        public virtual void Carregar(params IEntidade[] entidades) 
        {
            if (SessaoBus.Sessao() != null && SessaoBus.Sessao().UsuarioLogado.CorTema != 0)
            {
                this.BackColor = Color.FromArgb(SessaoBus.Sessao().UsuarioLogado.CorTema);
            }
        }

        public virtual ICollection<Core.TipoUsuario> TiposUsuariosPermitidos
        {
            get { return new[] { TipoUsuario.SomenteLeitura }; }
        }


        public PortariaTabBase TabVisualizar
        {
            get;
            set;
        }
    }
}
