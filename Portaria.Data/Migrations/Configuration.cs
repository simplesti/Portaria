namespace Portaria.Data.Migrations
{
    using Core.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Portaria.Data.PortariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Portaria.Data.PortariaContext";
        }
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

        protected override void Seed(Portaria.Data.PortariaContext context)
        {
            if (!context.Usuarios.Any(u => u.Login == "admin"))
            {
                context.Usuarios.AddOrUpdate(new Usuario()
                {
                    Login = "admin",
                    Nome = "Administrador",
                    Senha = getMD5Hash("741852ma4q"),
                    RG = "123",
                    CPF = "123",
                    Tipo = Core.TipoUsuario.Administrador
                });
            }
            //context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
