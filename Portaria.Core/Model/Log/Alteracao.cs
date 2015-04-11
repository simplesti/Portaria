using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model.Log
{
    public class Alteracao : IEntidade
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string NomeTipoEntidade { get; set; }

        public TipoAlteracao TipoAlteracao { get; set; }

        public int IdEntidade { get; set; }

        public string EntidadeOriginal { get; set; }

        public string EntidadeAlterada { get; set; }

        public DateTime Data { get; set; }

        public int IdSessao { get; set; }


        public string TipoEntidade
        {
            get { return "Alteracao"; }
        }

        public string DescricaoEntidade
        {
            get { return Descricao; }
        }
    }
}
