using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portaria.Core.Model.CadastroMorador;

namespace Portaria.Data
{
    public class PortariaContext : DbContext
    {
        public static PortariaContext BD
        {
            get 
            { 
                if (bd == null)
                {
                    bd = new PortariaContext();
                }

                return bd; 
            }
        }

        private static PortariaContext bd;

        public IDbSet<Bloco> Blocos { get; set; }

        public IDbSet<Unidade> Unidades { get; set; }

        public IDbSet<Veiculo> Veiculos { get; set; }

        public IDbSet<Pessoa> Pessoas { get; set; }

        public IDbSet<Funcionario> Funcionarios { get; set; }

        public PortariaContext() : base("PortariaContext")
        {
            
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

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

            base.OnModelCreating(modelBuilder);
        }

        public static void Refrescar()
        {
            bd = new PortariaContext();
        }
    }
}
