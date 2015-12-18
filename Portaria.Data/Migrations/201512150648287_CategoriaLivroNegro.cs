namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriaLivroNegro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriasLivroNegro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.RegistrosLivroNegro", "Categoria_Id", c => c.Int());
            CreateIndex("dbo.RegistrosLivroNegro", "Categoria_Id");
            AddForeignKey("dbo.RegistrosLivroNegro", "Categoria_Id", "dbo.CategoriasLivroNegro", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistrosLivroNegro", "Categoria_Id", "dbo.CategoriasLivroNegro");
            DropIndex("dbo.RegistrosLivroNegro", new[] { "Categoria_Id" });
            DropColumn("dbo.RegistrosLivroNegro", "Categoria_Id");
            DropTable("dbo.CategoriasLivroNegro");
        }
    }
}
