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

        [Required(ErrorMessage = "Campo 'Nome' deve ser preenchido.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo 'CPF' deve ser preenchido.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo 'RG' deve ser preenchido.")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Campo 'Login' deve ser preenchido.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo 'Senha' deve ser preenchido.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo 'Tipo' deve ser preenchido.")]
        public TipoUsuario Tipo { get; set; }

        public byte[] Biometria { get; set; }

        public int CorTema { get; set; }

        public bool PesquisaDetalhadaPadrao { get; set; }

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
