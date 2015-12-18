using Portaria.Business;
using Portaria.Core.Model;
using Portaria.Desktop.Framework.Forms;
using System;

namespace Portaria.LivroNegro
{
    public partial class CadCategoriaLivroNegro : FormBaseWindow
    {
        private CategoriaLivroNegro categoriaLivroNegro;

        public CategoriaLivroNegro CategoriaLivroNegro
        {
            get
            {
                return categoriaLivroNegro;
            }

            set
            {
                categoriaLivroNegro = value;
                bsCategoria.DataSource = categoriaLivroNegro;
            }
        }

        public CadCategoriaLivroNegro()
        {
            InitializeComponent();
            CategoriaLivroNegro = new CategoriaLivroNegro();
        }

        public CadCategoriaLivroNegro(CategoriaLivroNegro categoria)
        {
            InitializeComponent();
            CategoriaLivroNegro = categoria;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var categoriaBus = new CategoriaLivroNegroBus(SessaoAtual.Sessao);
            categoriaBus.InserirOuAtualizar(CategoriaLivroNegro);

            Close();
        }
    }
}
