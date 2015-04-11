using Newtonsoft.Json;
using Portaria.Core.Model;
using Portaria.Core.Model.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Log
{
    public static class PortariaLog
    {
        private static PortariaLogContext bd = new PortariaLogContext();

        public static void Aquecer()
        {
            var dummy = bd.Alteracoes.FirstOrDefault();
        }

        public static string SerializarEntidade(IEntidade entidade)
        {
            return JsonConvert.SerializeObject(entidade, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }

        public static void Logar(int idEntidade, string entidadeOriginal, string entidadeAlterada, string nomeTipoEntidade,int idSecao, TipoAlteracao tipoAlteracao, string descricao = null)
        {
            var alteracao = new Alteracao();
            alteracao.TipoAlteracao = tipoAlteracao;
            alteracao.Data = DateTime.Now;

            alteracao.EntidadeOriginal = entidadeOriginal;
            alteracao.EntidadeAlterada = entidadeAlterada;

            alteracao.IdSessao = idSecao;

            if (!string.IsNullOrEmpty(descricao))
            {
                alteracao.Descricao = descricao;
            }

            alteracao.IdEntidade = idEntidade;
            alteracao.NomeTipoEntidade = nomeTipoEntidade;

            bd.Alteracoes.Add(alteracao);
            bd.SaveChanges();
        }
    }
}
