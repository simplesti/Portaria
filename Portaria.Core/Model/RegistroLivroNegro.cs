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

        public virtual Sessao Sessao { get; set; }

        public string Mensagem { get; set; }

        public virtual ICollection<RegistroLivroNegroEntidade> Entidades { get; set; }


        public string TipoEntidade()
        {
            return GetType().Name;
        }

        public string DescricaoEntidade()
        {
            return string.Format("Registro do livro negro Id {0}", Id.ToString());
        }

        public override string ToString()
        {
            return DescricaoEntidade();
        }
    }
}
