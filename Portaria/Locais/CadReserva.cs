﻿using Portaria.Business;
using Portaria.Cadastro;
using Portaria.Core.Model;
using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Framework.Forms;

namespace Portaria.Locais
{
    public partial class CadReserva : FormBaseWindow
    {
        private Reserva reserva;
        
        public Reserva Reserva
        {
            get
            {
                return reserva; 
            }

            set
            {
                reserva = value;
                txtLocal.Text = reserva.Local.Nome;

                if (reserva.Pessoa != null)
                {
                    txtSolicitante.Text = reserva.Pessoa.Nome;
                }

                bsReserva.DataSource = reserva;
            }
        }

        public CadReserva(Local local)
        {
            InitializeComponent();

            Reserva = new Reserva() { Local = local };
        }

        public CadReserva(Reserva reserva)
        {
            InitializeComponent();

            Reserva = reserva;
        }

        private void botaoEditarSolicitante_Click(object sender, System.EventArgs e)
        {
            EditarSolicitante();
        }

        private void EditarSolicitante()
        {
            Reserva.Pessoa = SelecionaPessoa.Selecionar();

            if (Reserva.Pessoa != null)
            {
                txtSolicitante.Text = Reserva.Pessoa.Nome;
            }
            else
            {
                txtSolicitante.Text = string.Empty;
            }
        }

        private void botaoCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, System.EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var reservaBus = new ReservaBus();
            reservaBus.InserirOuAtualizar(Reserva);

            Close();
        }
    }
}
