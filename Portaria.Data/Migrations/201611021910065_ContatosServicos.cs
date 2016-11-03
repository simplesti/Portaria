namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContatosServicos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContatosServicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        TipoServico = c.Int(nullable: false),
                        Telefone = c.String(),
                        Endereco = c.String(),
                        Observacao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContatosServicos");
        }
    }
}
