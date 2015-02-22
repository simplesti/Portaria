using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model.CadastroMorador
{
    public class Veiculo : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public byte[] Foto { get; set; }

        public virtual Unidade Unidade { get; set; }

        public virtual Pessoa Proprietario { get; set; }


        public string TipoEntidade
        {
            get { return typeof(Veiculo).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("{0} cor {1} placa {2}", Nome, Cor, Placa);
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
