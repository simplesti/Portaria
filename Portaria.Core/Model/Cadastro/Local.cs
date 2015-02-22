using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model.Cadastro
{
    public class Local : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public byte[] Foto { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }


        public string TipoEntidade
        {
            get { return typeof(Local).Name; }
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
