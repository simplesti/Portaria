namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransformandoBlocosEmEntidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blocos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Unidades", "Bloco_Id", c => c.Int());
            CreateIndex("dbo.Unidades", "Bloco_Id");
            AddForeignKey("dbo.Unidades", "Bloco_Id", "dbo.Blocos", "Id");
            DropColumn("dbo.Unidades", "Bloco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Unidades", "Bloco", c => c.String());
            DropForeignKey("dbo.Unidades", "Bloco_Id", "dbo.Blocos");
            DropIndex("dbo.Unidades", new[] { "Bloco_Id" });
            DropColumn("dbo.Unidades", "Bloco_Id");
            DropTable("dbo.Blocos");
        }
    }
}
