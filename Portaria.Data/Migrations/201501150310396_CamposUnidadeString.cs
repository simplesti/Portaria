namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposUnidadeString : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animais", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Assinaturas", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Veiculos", "Unidade_Id", "dbo.Unidades");
            DropIndex("dbo.Animais", new[] { "Unidade_Id" });
            DropIndex("dbo.Assinaturas", new[] { "Unidade_Id" });
            DropIndex("dbo.Veiculos", new[] { "Unidade_Id" });
            AddColumn("dbo.Unidades", "Animais", c => c.String());
            AddColumn("dbo.Unidades", "Veiculos", c => c.String());
            AddColumn("dbo.Unidades", "Assinaturas", c => c.String());
            DropTable("dbo.Animais");
            DropTable("dbo.Assinaturas");
            DropTable("dbo.Veiculos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        Marca = c.String(),
                        Placa = c.String(),
                        Cor = c.String(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Assinaturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Frequencia = c.String(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Animais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Unidades", "Assinaturas");
            DropColumn("dbo.Unidades", "Veiculos");
            DropColumn("dbo.Unidades", "Animais");
            CreateIndex("dbo.Veiculos", "Unidade_Id");
            CreateIndex("dbo.Assinaturas", "Unidade_Id");
            CreateIndex("dbo.Animais", "Unidade_Id");
            AddForeignKey("dbo.Veiculos", "Unidade_Id", "dbo.Unidades", "Id");
            AddForeignKey("dbo.Assinaturas", "Unidade_Id", "dbo.Unidades", "Id");
            AddForeignKey("dbo.Animais", "Unidade_Id", "dbo.Unidades", "Id");
        }
    }
}
