using Portaria.Core.Model.Log;
using System.Data.Entity;

namespace Portaria.Log
{
    public class PortariaLogContext : DbContext
    {
        public IDbSet<Alteracao> Alteracoes { get; set; }
        public PortariaLogContext()
            : base("PortariaLogContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alteracao>()
                .ToTable("Alteracoes");

            base.OnModelCreating(modelBuilder);
        }
    }
}