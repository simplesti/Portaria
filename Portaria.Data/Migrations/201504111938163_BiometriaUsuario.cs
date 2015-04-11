namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BiometriaUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "CPF", c => c.String());
            AddColumn("dbo.Usuarios", "RG", c => c.String());
            AddColumn("dbo.Usuarios", "Biometria", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Biometria");
            DropColumn("dbo.Usuarios", "RG");
            DropColumn("dbo.Usuarios", "CPF");
        }
    }
}
