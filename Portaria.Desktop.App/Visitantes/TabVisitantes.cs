using MaterialSkin.Controls;
using Portaria.Business;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Desktop.Framework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portaria.Visitantes
{
    public partial class TabVisitantes : PortariaTabBase
    {
        private Visitante visitante;

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Porteiro };
            }
        }

        public TabVisitantes()
        {
            InitializeComponent();

            Novo();
        }

        private void btnSelecionarUnidade_Click(object sender, EventArgs e)
        {
            SelecionarUnidade();
        }

        private void SelecionarUnidade()
        {
            visitante.Unidade = SelecionaEntidade.SelecionarUnidade();
            if (visitante.Unidade != null)
            {
                txtUnidade.Text = visitante.Unidade.ToString();
            }
            else
            {
                txtUnidade.Text = string.Empty;
            }
        }

        private void rbtCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (((MaterialRadioButton)sender).Checked)
            {
                txtDocumento.Mask = "000,000,000-00";
            }
        }

        private void rbtRG_CheckedChanged(object sender, EventArgs e)
        {
            if (((MaterialRadioButton)sender).Checked)
            {
                txtDocumento.Mask = string.Empty;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

            Novo();

            Carregar();
        }

        private void Salvar()
        {
            var visitanteBus = new VisitanteBus(SessaoAtual.Sessao);
            visitanteBus.InserirOuAtualizar(visitante);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Novo()
        {
            visitante = new Visitante();
            bsVisitante.DataSource = visitante;
        }
        
        private void Carregar()
        {
            var visitanteBus = new VisitanteBus(SessaoAtual.Sessao);
            bsListaVisitantes.DataSource = visitanteBus.BuscarDoMes().ToList();
        }
    }
}
