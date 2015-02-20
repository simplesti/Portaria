using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using System;

namespace Portaria.Core.Model
{
    public class Reserva : IModel
    {
        public int Id { get; set; }

        public DateTime DataHora { get; set; }

        public DateTime DataHoraInicio { get; set; }

        public DateTime DataHoraFim { get; set; }

        public virtual Local Local { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual Sessao Sessao { get; set; }
    }
}
