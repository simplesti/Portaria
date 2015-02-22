namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PessoaNoRegistro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegistrosLivroNegro", "Pessoa_Id", c => c.Int());
            CreateIndex("dbo.RegistrosLivroNegro", "Pessoa_Id");
            AddForeignKey("dbo.RegistrosLivroNegro", "Pessoa_Id", "dbo.Pessoas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistrosLivroNegro", "Pessoa_Id", "dbo.Pessoas");
            DropIndex("dbo.RegistrosLivroNegro", new[] { "Pessoa_Id" });
            DropColumn("dbo.RegistrosLivroNegro", "Pessoa_Id");
        }
    }
}
