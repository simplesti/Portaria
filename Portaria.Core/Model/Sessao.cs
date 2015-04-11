using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class Sessao : IEntidade
    {
        public int Id { get; set; }

        public DateTime? DataHoraInicio { get; set; }

        public DateTime? DataHoraFim { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Usuario UsuarioLogado { get; set; }

        public string NomeEstacao { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Reserva> Reservas { get; set; }


        public string TipoEntidade
        {
            get { return typeof(Sessao).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("{0} - {1} ({2})", DataHoraInicio.Value.ToString("dd/MM/yyyy HH:mm"),
                    DataHoraFim.HasValue ? DataHoraFim.Value.ToString("dd/MM/yyyy HH:mm") : "", UsuarioLogado.Nome);
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
