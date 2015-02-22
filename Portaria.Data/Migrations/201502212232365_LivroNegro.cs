namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LivroNegro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistroLivroNegroEntidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdModelo = c.Int(nullable: false),
                        Tipo = c.String(),
                        RegistroLivroNegro_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RegistrosLivroNegro", t => t.RegistroLivroNegro_Id)
                .Index(t => t.RegistroLivroNegro_Id);
            
            CreateTable(
                "dbo.RegistrosLivroNegro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mensagem = c.String(),
                        Sessao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessoes", t => t.Sessao_Id)
                .Index(t => t.Sessao_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistrosLivroNegro", "Sessao_Id", "dbo.Sessoes");
            DropForeignKey("dbo.RegistroLivroNegroEntidades", "RegistroLivroNegro_Id", "dbo.RegistrosLivroNegro");
            DropIndex("dbo.RegistrosLivroNegro", new[] { "Sessao_Id" });
            DropIndex("dbo.RegistroLivroNegroEntidades", new[] { "RegistroLivroNegro_Id" });
            DropTable("dbo.RegistrosLivroNegro");
            DropTable("dbo.RegistroLivroNegroEntidades");
        }
    }
}
