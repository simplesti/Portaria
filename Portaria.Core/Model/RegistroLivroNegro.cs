using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portaria.Core.Model.CadastroMorador;

namespace Portaria.Core.Model
{
    public class RegistroLivroNegro : IEntidade
    {
        public int Id { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Pessoa Pessoa { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Sessao Sessao { get; set; }

        public DateTime Data { get; set; }

        public string Mensagem { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<RegistroLivroNegroEntidade> Entidades { get; set; }

        public string TipoEntidade
        {
            get { return typeof(RegistroLivroNegro).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("Registro do livro negro Id {0}", Id.ToString());
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
