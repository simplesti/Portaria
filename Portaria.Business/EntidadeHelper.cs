using Portaria.Business.Cadastro;
using Portaria.Core.Model;
using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public class EntidadeHelper
    {
        private PortariaContext bd;

        public EntidadeHelper()
        {
            bd = PortariaContext.BD;
        }

        public IEnumerable<IEntidade> BuscaEntidades(ICollection<RegistroLivroNegroEntidade> registroLivroNegroEntidades)
        {
            List<IEntidade> retorno = new List<IEntidade>();

            foreach (var registroEntidade in registroLivroNegroEntidades)
            {
                if (registroEntidade.Tipo == typeof(Pessoa).Name)
                {
                    var pessoaBus = new PessoaBus();
                    retorno.Add(pessoaBus.BuscaPorId(registroEntidade.IdEntidade));
                }
                else if (registroEntidade.Tipo == typeof(Veiculo).Name)
                {
                    var veiculoBus = new VeiculoBus();
                    retorno.Add(veiculoBus.BuscaPorId(registroEntidade.IdEntidade));
                }
                else if (registroEntidade.Tipo == typeof(Unidade).Name)
                {
                    var unidadeBus = new UnidadeBus();
                    retorno.Add(unidadeBus.BuscaPorId(registroEntidade.IdEntidade));
                }
                else if (registroEntidade.Tipo == typeof(Local).Name)
                {
                    var localBus = new LocalBus();
                    retorno.Add(localBus.BuscaPorId(registroEntidade.IdEntidade));
                }
                else if (registroEntidade.Tipo == typeof(Funcionario).Name)
                {
                    var funcionarioBus = new FuncionarioBus();
                    retorno.Add(funcionarioBus.BuscaPorId(registroEntidade.IdEntidade));
                }
                else if (registroEntidade.Tipo == typeof(Bloco).Name)
                {
                    var blocoBus = new BlocoBus();
                    retorno.Add(blocoBus.BuscaPorId(registroEntidade.IdEntidade));
                }
                else if (registroEntidade.Tipo == typeof(Usuario).Name)
                {
                    var usuarioBus = new UsuarioBus();
                    retorno.Add(usuarioBus.BuscaPorId(registroEntidade.IdEntidade));
                }
            }

            return retorno;
        }

        public IEnumerable<IEntidade> BuscaPorDescricao(string descricaoEntidade, string tipoEntidade)
        {
            List<IEntidade> retorno = null;

            if (tipoEntidade == typeof(Pessoa).Name)
            {
                var itens = bd.Pessoas.Where(p => p.Nome.ToUpper().Contains(descricaoEntidade.ToUpper())).ToList();
                retorno = itens.Cast<IEntidade>().ToList();
            }
            else if (tipoEntidade == typeof(Veiculo).Name)
            {
                var itens = bd.Veiculos.Where(v => v.Placa.ToUpper().Contains(descricaoEntidade.ToUpper())).ToList();
                retorno = itens.Cast<IEntidade>().ToList();
            }
            else if (tipoEntidade == typeof(Unidade).Name)
            {
                var itens = bd.Unidades.Where(u => u.Numero.ToString().Contains(descricaoEntidade)).ToList();
                retorno = itens.Cast<IEntidade>().ToList();
            }
            else if (tipoEntidade == typeof(Local).Name)
            {
                var itens = bd.Locais.Where(l => l.Nome.ToUpper().Contains(descricaoEntidade.ToUpper())).ToList();
                retorno = itens.Cast<IEntidade>().ToList();
            }
            else if (tipoEntidade == typeof(Funcionario).Name)
            {
                var itens = bd.Funcionarios.Where(f => f.Nome.ToUpper().Contains(descricaoEntidade.ToUpper())).ToList();
                retorno = itens.Cast<IEntidade>().ToList();
            }
            else if (tipoEntidade == typeof(Bloco).Name)
            {
                var itens = bd.Blocos.Where(b => b.Nome.ToUpper().Contains(descricaoEntidade.ToUpper())).ToList();
                retorno = itens.Cast<IEntidade>().ToList();
            }
            else if (tipoEntidade == typeof(Usuario).Name)
            {
                var itens = bd.Usuarios.Where(u => u.Nome.ToUpper().Contains(descricaoEntidade.ToUpper())).ToList();
                retorno = itens.Cast<IEntidade>().ToList();
            }

            return retorno;
        }


        public string BuscaDescricao(string variavel)
        {
            var id = int.Parse(variavel.Substring(5, variavel.IndexOf(';') - 5));
            var tipo = variavel.Remove(0, variavel.IndexOf(';') + 6).TrimEnd('#').TrimEnd('!');

            if (tipo == typeof(Pessoa).Name)
            {
                var pessoaBus = new PessoaBus();
                var pessoa = pessoaBus.BuscaPorId(id);

                return pessoa.DescricaoEntidade;
            }
            else if (tipo == typeof(Veiculo).Name)
            {
                var veiculoBus = new VeiculoBus();
                var veiculo = veiculoBus.BuscaPorId(id);

                return veiculo.DescricaoEntidade;
            }
            else if (tipo == typeof(Unidade).Name)
            {
                var unidadeBus = new UnidadeBus();
                var unidade = unidadeBus.BuscaPorId(id);

                return unidade.DescricaoEntidade;
            }
            else if (tipo == typeof(Local).Name)
            {
                var localBus = new LocalBus();
                var local = localBus.BuscaPorId(id);

                return local.DescricaoEntidade;
            }
            else if (tipo == typeof(Funcionario).Name)
            {
                var funcionarioBus = new FuncionarioBus();
                var funcionario = funcionarioBus.BuscaPorId(id);

                return funcionario.DescricaoEntidade;
            }
            else if (tipo == typeof(Bloco).Name)
            {
                var blocoBus = new BlocoBus();
                var bloco = blocoBus.BuscaPorId(id);

                return bloco.DescricaoEntidade;
            }
            else if (tipo == typeof(Usuario).Name)
            {
                var usuarioBus = new UsuarioBus();
                var usuario = usuarioBus.BuscaPorId(id);

                return usuario.DescricaoEntidade;
            }

            return "";
        }

        public List<Tuple<string, int, int>> BuscaVariaveis(string texto)
        {
            var variaveis = new List<Tuple<string, int, int>>();

            var regex = new Regex(@"\#\!(Id=)[\w]*\;(Tipo=)[\w]*\!\#");

            foreach (Match m in regex.Matches(texto))
            {
                variaveis.Add(new Tuple<string, int, int>(m.Value, m.Index, m.Length));
            }

            return variaveis;
        }
    }
}
