namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PesquisaDetalhadaPadrao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "PesquisaDetalhadaPadrao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "PesquisaDetalhadaPadrao");
        }
    }
}
