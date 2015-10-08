namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposUsuarioNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "CPF", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "RG", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "RG", c => c.String());
            AlterColumn("dbo.Usuarios", "CPF", c => c.String());
            AlterColumn("dbo.Usuarios", "Nome", c => c.String());
        }
    }
}
