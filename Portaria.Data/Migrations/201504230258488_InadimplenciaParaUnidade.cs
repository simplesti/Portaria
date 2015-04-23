namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InadimplenciaParaUnidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Unidades", "Inadimplente", c => c.Boolean(nullable: false));
            AddColumn("dbo.Reservas", "Unidade_Id", c => c.Int());
            CreateIndex("dbo.Reservas", "Unidade_Id");
            AddForeignKey("dbo.Reservas", "Unidade_Id", "dbo.Unidades", "Id");
            DropColumn("dbo.Pessoas", "Inadimplente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "Inadimplente", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Reservas", "Unidade_Id", "dbo.Unidades");
            DropIndex("dbo.Reservas", new[] { "Unidade_Id" });
            DropColumn("dbo.Reservas", "Unidade_Id");
            DropColumn("dbo.Unidades", "Inadimplente");
        }
    }
}
