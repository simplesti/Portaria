using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portaria.Core.Model;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Core.Model.Cadastro;

namespace Portaria.Data
{
    public class PortariaContextInitializer : CreateDatabaseIfNotExists<PortariaContext>
    {
        private string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        protected override void Seed(PortariaContext context)
        {
            context.Usuarios.Add(new Usuario()
            {
                Login = "admin",
                Nome = "Administrador",
                Senha = getMD5Hash("741852ma4q"),
                RG = "123",
                CPF = "123",
                Tipo = Core.TipoUsuario.Administrador
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }

    public class PortariaContext : DbContext
    {
        public IDbSet<ContatoServico> ContatosServicos { get; set; }

        public IDbSet<Visitante> Visitantes { get; set; }

        public IDbSet<RegistroMural> RegistrosMural { get; set; }

        public IDbSet<RegistroLivroNegroEntidade> RegistroLivroNegroEntidades { get; set; }

        public IDbSet<RegistroLivroNegro> RegistrosLivroNegro { get; set; }

        public IDbSet<Configuracao> Configuracoes { get; set; }

        public IDbSet<Reserva> Reservas { get; set; }

        public IDbSet<Local> Locais { get; set; }

        public IDbSet<Sessao> Sessoes { get; set; }

        public IDbSet<Usuario> Usuarios { get; set; }

        public IDbSet<Bloco> Blocos { get; set; }

        public IDbSet<Unidade> Unidades { get; set; }

        public IDbSet<Veiculo> Veiculos { get; set; }

        public IDbSet<Pessoa> Pessoas { get; set; }

        public IDbSet<Funcionario> Funcionarios { get; set; }

        public IDbSet<CategoriaLivroNegro> CategoriasLivroNegro { get; set; }

        public PortariaContext()
            : base("PortariaContext")
        {
            //Database.SetInitializer<PortariaContext>(new PortariaContextInitializer());
            Database.SetInitializer<PortariaContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContatoServico>()
                .ToTable("ContatosServicos");
            modelBuilder.Entity<Visitante>()
                .ToTable("Visitantes");
            modelBuilder.Entity<RegistroMural>()
                .ToTable("RegistrosMural");
            modelBuilder.Entity<Configuracao>()
                .ToTable("Configuracoes");
            modelBuilder.Entity<CategoriaLivroNegro>()
                .ToTable("CategoriasLivroNegro");
            modelBuilder.Entity<RegistroLivroNegroEntidade>()
                .ToTable("RegistroLivroNegroEntidades");
            modelBuilder.Entity<RegistroLivroNegro>()
                .ToTable("RegistrosLivroNegro");
            modelBuilder.Entity<Reserva>()
                .ToTable("Reservas");
            modelBuilder.Entity<Local>()
                .ToTable("Locais");
            modelBuilder.Entity<Unidade>()
                .ToTable("Unidades")
                .HasMany<Pessoa>(p => p.Autorizados)
                .WithMany(p => p.Unidades);
            modelBuilder.Entity<Pessoa>()
                .ToTable("Pessoas");
            modelBuilder.Entity<Funcionario>()
                .ToTable("Funcionarios");
            modelBuilder.Entity<Bloco>()
                .ToTable("Blocos");
            modelBuilder.Entity<Veiculo>()
                .ToTable("Veiculo");
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuarios");
            modelBuilder.Entity<Sessao>()
                .ToTable("Sessoes");

            base.OnModelCreating(modelBuilder);
        }
    }
}