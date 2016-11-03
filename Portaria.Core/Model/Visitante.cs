using Portaria.Core.Model.CadastroMorador;
using System;

namespace Portaria.Core.Model
{
    public class Visitante : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public DateTime DataHoraChegada { get; set; }

        public DateTime DataHoraSaida { get; set; }

        public virtual Unidade Unidade { get; set; }

        public virtual Usuario Usuario { get; set; }

        public string TipoEntidade
        {
            get { return typeof(Visitante).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("Visitante Id {0}", Id.ToString());
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
