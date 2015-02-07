namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sessoes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sessoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHoraInicio = c.DateTime(),
                        DataHoraFim = c.DateTime(),
                        NomeEstacao = c.String(),
                        UsuarioLogado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioLogado_Id)
                .Index(t => t.UsuarioLogado_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessoes", "UsuarioLogado_Id", "dbo.Usuarios");
            DropIndex("dbo.Sessoes", new[] { "UsuarioLogado_Id" });
            DropTable("dbo.Sessoes");
        }
    }
}
