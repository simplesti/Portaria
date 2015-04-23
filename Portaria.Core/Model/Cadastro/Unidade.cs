using System.Collections.Generic;
using System;

namespace Portaria.Core.Model.CadastroMorador
{
    public class Unidade : IEntidade
    {
        public Unidade()
        {
            Autorizados = new List<Pessoa>();
            Funcionarios = new List<Funcionario>();
            Veiculos = new List<Veiculo>();
        }
        public int Id { get; set; }

        public int Numero { get; set; }

        public string AparelhosGas { get; set; }

        public bool Inadimplente { get; set; }

        public string Observacoes { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Pessoa Proprietario { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Pessoa Conjuge { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Pessoa Locatario { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Pessoa> Autorizados { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Reserva> Reservas { get; set; }

        public string Animais { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Veiculo> Veiculos { get; set; }

        public string Assinaturas { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Bloco Bloco { get; set; }


        public string TipoEntidade
        {
            get { return typeof(Unidade).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return Bloco != null ? Bloco.Nome + " - " + Numero.ToString() : Numero.ToString();
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
