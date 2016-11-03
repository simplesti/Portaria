namespace Portaria.Core.Model
{
    public class ContatoServico : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public TipoContatoServico TipoServico { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public string Observacao { get; set; }

        public string TipoEntidade
        {
            get { return typeof(ContatoServico).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("Contato de serviço Id {0}", Id.ToString());
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
