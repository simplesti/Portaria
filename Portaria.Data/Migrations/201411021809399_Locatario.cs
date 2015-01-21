namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Locatario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Unidades", "Locatario_Id", c => c.Int());
            CreateIndex("dbo.Unidades", "Locatario_Id");
            AddForeignKey("dbo.Unidades", "Locatario_Id", "dbo.Pessoas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Unidades", "Locatario_Id", "dbo.Pessoas");
            DropIndex("dbo.Unidades", new[] { "Locatario_Id" });
            DropColumn("dbo.Unidades", "Locatario_Id");
        }
    }
}
