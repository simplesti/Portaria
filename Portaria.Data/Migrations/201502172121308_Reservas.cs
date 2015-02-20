namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reservas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        DataHoraInicio = c.DateTime(nullable: false),
                        DataHoraFim = c.DateTime(nullable: false),
                        Local_Id = c.Int(),
                        Pessoa_Id = c.Int(),
                        Sessao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locais", t => t.Local_Id)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id)
                .ForeignKey("dbo.Sessoes", t => t.Sessao_Id)
                .Index(t => t.Local_Id)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Sessao_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Sessao_Id", "dbo.Sessoes");
            DropForeignKey("dbo.Reservas", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Reservas", "Local_Id", "dbo.Locais");
            DropIndex("dbo.Reservas", new[] { "Sessao_Id" });
            DropIndex("dbo.Reservas", new[] { "Pessoa_Id" });
            DropIndex("dbo.Reservas", new[] { "Local_Id" });
            DropTable("dbo.Reservas");
        }
    }
}
