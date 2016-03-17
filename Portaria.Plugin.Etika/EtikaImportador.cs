using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Plugin.Etika
{
    public class EtikaImportador
    {
        public void ImportarInadimplencia(IEnumerable<int> unidadesInadimplentes)
        {
            var unidadeBus = GerenciadorPlugins.Buscar<Unidade>();

            var unidadesInadimplentesAtual = unidadeBus.Todos().Where(u => u.Inadimplente).ToList();

            //Verifica as unidades inadimplentes atualmente se estao na lista atualizada da Etika, se nao tiver, tira o inadimplente.
            foreach (var unidade in unidadesInadimplentesAtual)
            {
                unidade.Inadimplente = unidadesInadimplentes.Contains(unidade.Numero);
                unidadeBus.InserirOuAtualizar(unidade);
            }

            //Varre a lista atualizada da etika e seta como inadimplente os aptos.
            var novasUnidadesInadimplentes = unidadeBus.Todos().Where(u => unidadesInadimplentes.Contains(u.Numero)).ToList();
            foreach (var unidade in novasUnidadesInadimplentes)
            {
                unidade.Inadimplente = true;
                unidadeBus.InserirOuAtualizar(unidade);
            }
        }
    }
}
