using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using System;

namespace Portaria.Core.Model
{
    public class Reserva : IEntidade
    {
        public int Id { get; set; }

        public DateTime DataHora { get; set; }

        public DateTime DataHoraInicio { get; set; }

        public DateTime DataHoraFim { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Unidade Unidade { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Local Local { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Pessoa Pessoa { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Sessao Sessao { get; set; }


        public string TipoEntidade
        {
            get { return typeof(Reserva).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("Local: {0} ({1} - {2})", Local.Nome, DataHoraInicio.ToString("dd/MM/yyyy HH:mm"),
                    DataHoraFim.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
