namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Visitantes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Documento = c.String(),
                        DataHoraChegada = c.DateTime(nullable: false),
                        DataHoraSaida = c.DateTime(nullable: false),
                        Unidade_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Unidade_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitantes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Visitantes", "Unidade_Id", "dbo.Unidades");
            DropIndex("dbo.Visitantes", new[] { "Usuario_Id" });
            DropIndex("dbo.Visitantes", new[] { "Unidade_Id" });
            DropTable("dbo.Visitantes");
        }
    }
}
