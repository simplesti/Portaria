using System;

namespace Portaria.Core.Model
{
    public class RegistroMural : IEntidade
    {
        public int Id { get; set; }

        public string Mensagem { get; set; }

        public DateTime DataHora { get; set; }

        public virtual Usuario Usuario { get; set; }

        public string TipoEntidade
        {
            get { return typeof(RegistroMural).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("Registro do mural Id {0}", Id.ToString());
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
