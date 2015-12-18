using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Portaria.Business;
using Portaria.Desktop.Framework.Forms;
using System.Collections.Generic;

namespace Portaria.Desktop.Framework
{
    public class PortariaTabControl : TabControl
    {
        private PortariaTabPage predraggedTab;

        private List<PortariaTabPage> tabs = new List<PortariaTabPage>();

        public PortariaTabControl()
        {
            this.AllowDrop = true;
        }

        public void Restaurar()
        {
            foreach(PortariaTabPage tp in this.TabPages)
            {
                tabs.Add(tp);
            }

            ValidaPermissoes();

            RestauraPosicoes();

            CarregarTab();
        }

        private void CarregarTab()
        {
            var portariaTab = this.SelectedTab.Controls[0] as PortariaTabBase;
            if (portariaTab != null)
            {
                portariaTab.Carregar();
            }
        }

        private void RestauraPosicoes()
        {
            if (SessaoAtual.Sessao != null)
            {
                var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);
                var u = usuarioBus.BuscarPorId(SessaoAtual.Sessao.UsuarioLogado.Id);

                if (!string.IsNullOrEmpty(u.PosicaoAbas))
                {
                    var posicoes = JsonConvert.DeserializeObject<Dictionary<string, int>>(u.PosicaoAbas);

                    foreach(PortariaTabPage tab in this.TabPages)
                    {
                        int srcIndex = this.TabPages.IndexOf(tab);
                        int savedIndex = posicoes[tab.Name];

                        if ( srcIndex != savedIndex)
                        {
                            var tabOrigem = this.TabPages[srcIndex];
                            var tabDestino = this.TabPages[savedIndex];

                            this.TabPages[srcIndex] = tabDestino;
                            this.TabPages[savedIndex] = tabOrigem;
                        }
                    }
                }
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            CarregarTab();
        }

        private void ValidaPermissoes()
        {
            foreach (PortariaTabPage tabPage in tabs)
            {
                if (!((IPortariaTab)tabPage.Controls[0]).TiposUsuariosPermitidos.Contains(SessaoAtual.Sessao.UsuarioLogado.Tipo))
                {
                    this.Controls.Remove(tabPage);
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            predraggedTab = getPointedTab();

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            predraggedTab = null;

            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && predraggedTab != null)
                this.DoDragDrop(predraggedTab, DragDropEffects.Move);

            base.OnMouseMove(e);
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            PortariaTabPage draggedTab = (PortariaTabPage)drgevent.Data.GetData(typeof(PortariaTabPage));
            PortariaTabPage pointedTab = getPointedTab();

            if (draggedTab == predraggedTab && pointedTab != null)
            {
                drgevent.Effect = DragDropEffects.Move;

                if (pointedTab != draggedTab)
                    swapTabPages(draggedTab, pointedTab);
            }

            base.OnDragOver(drgevent);
        }

        private PortariaTabPage getPointedTab()
        {
            for (int i = 0; i < this.TabPages.Count; i++)
                if (this.GetTabRect(i).Contains(this.PointToClient(Cursor.Position)))
                    return (PortariaTabPage)this.TabPages[i];

            return null;
        }

        private void swapTabPages(PortariaTabPage src, PortariaTabPage dst)
        {
            int srci = this.TabPages.IndexOf(src);
            int dsti = this.TabPages.IndexOf(dst);

            this.TabPages[dsti] = src;
            this.TabPages[srci] = dst;

            if (this.SelectedIndex == srci)
                this.SelectedIndex = dsti;
            else if (this.SelectedIndex == dsti)
                this.SelectedIndex = srci;

            this.Refresh();

            SalvarPosicoes();
        }

        private void SalvarPosicoes()
        {
            var posicoes = new System.Collections.Generic.Dictionary<string, int>();

            foreach (PortariaTabPage tp in this.TabPages)
            {
                posicoes.Add(tp.Name, this.TabPages.IndexOf(tp));
            }

            var txt = JsonConvert.SerializeObject(posicoes);

            var usuarioBus = new UsuarioBus(SessaoAtual.Sessao);
            var u = usuarioBus.BuscarPorId(SessaoAtual.Sessao.UsuarioLogado.Id);
            u.PosicaoAbas = txt;

            usuarioBus.InserirOuAtualizar(u);
        }
    }
}