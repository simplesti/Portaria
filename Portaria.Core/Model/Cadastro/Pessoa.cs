
using System.Collections.Generic;
namespace Portaria.Core.Model.CadastroMorador
{
    public class Pessoa : IEntidade, IBiometria
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

        public byte[] Biometria { get; set; }

        public byte[] Foto { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Veiculo> Veiculos { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Unidade> Unidades { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Reserva> Reservas { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<RegistroLivroNegro> RegistrosLivroNegro { get; set; }


        public string TipoEntidade
        {
            get { return typeof(Pessoa).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return Nome;
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
