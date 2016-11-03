using MaterialSkin.Controls;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria.Desktop.Framework
{
    public class PortariaTabControl : MaterialTabControl
    {
        private void CarregarTab()
        {
            if (this.SelectedTab.Controls.Count > 0)
            {
                var portariaTab = this.SelectedTab.Controls[0] as PortariaTabBase;
                if (portariaTab != null)
                {
                    portariaTab.Carregar();
                }
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            CarregarTab();
        }

        public void ValidaPermissoes()
        {
            var tabsToRemove = new List<TabPage>();

            foreach (TabPage tp in Controls)
            {
                if (tp.Controls.Count > 0)
                {
                    var tab = (IPortariaTab)tp.Controls[0];
                    if (!tab.TiposUsuariosPermitidos.Any(q => q == SessaoAtual.Sessao.UsuarioLogado.Tipo))
                    {
                        tabsToRemove.Add(tp);
                    }
                }
            }

            foreach (var tab in tabsToRemove)
            {
                Controls.Remove(tab);
            }
        }
    }
}