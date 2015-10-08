using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class Usuario : IEntidade, IBiometria
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string RG { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        public TipoUsuario Tipo { get; set; }

        public byte[] Biometria { get; set; }

        public int CorTema { get; set; }

        public string PosicaoAbas { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Sessao> Sessoes { get; set; }

        public string TipoEntidade
        {
            get { return typeof(Usuario).Name; }
        }

        public string DescricaoEntidade
        {
            get { return Nome; }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
