﻿
using System.Collections.Generic;
namespace Portaria.Core.Model.CadastroMorador
{
    public class Pessoa : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string FoneResidencial { get; set; }

        public string FoneComercial { get; set; }

        public string FoneCelular { get; set; }

        public string Email { get; set; }

        public string GrauParentesco { get; set; }

        public bool Inadimplente { get; set; }

        public byte[] Foto { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }

        public virtual ICollection<Unidade> Unidades { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }


        public string TipoEntidade()
        {
            return GetType().Name;
        }

        public string DescricaoEntidade()
        {
            return Nome;
        }

        public override string ToString()
        {
            return DescricaoEntidade();
        }
    }
}
