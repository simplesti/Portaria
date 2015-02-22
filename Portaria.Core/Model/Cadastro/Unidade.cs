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

        public string Observacoes { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public virtual Pessoa Proprietario { get; set; }

        public virtual Pessoa Conjuge { get; set; }

        public virtual Pessoa Locatario { get; set; }

        public virtual ICollection<Pessoa> Autorizados { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        public string Animais { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }

        public string Assinaturas { get; set; }

        public virtual Bloco Bloco { get; set; }


        public string TipoEntidade()
        {
            return GetType().Name;
        }

        public string DescricaoEntidade()
        {
            return Numero.ToString();
        }

        public override string ToString()
        {
            return DescricaoEntidade();
        }
    }
}
