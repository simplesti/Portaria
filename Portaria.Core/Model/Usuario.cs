using System.Collections.Generic;

namespace Portaria.Core.Model
{
    public class Usuario : IEntidade, IBiometria
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string CPF { get; set; }
        
        public string RG { get; set; }

        public string Login { get; set; }
        
        public string Senha { get; set; }
        
        public TipoUsuario Tipo { get; set; }

        public string Biometria { get; set; }

        public int CorTema { get; set; }

        public bool ControleAcessoAutorizado { get; set; }

        public bool PesquisaDetalhadaPadrao { get; set; }

        public string PosicaoAbas { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual ICollection<Sessao> Sessoes { get; set; }

        public string TipoEntidade
        {
            get { return typeof(Usuario).Name; }
        }

        public string DescricaoEntidade
        {
            get { return Nome; }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
