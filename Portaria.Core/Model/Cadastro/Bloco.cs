using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model.CadastroMorador
{
    public class Bloco : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Unidade> Unidades { get; set; }

        public string TipoEntidade
        {
            get { return typeof(Bloco).Name; }
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
