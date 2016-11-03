namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrosMural : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistrosMural",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mensagem = c.String(),
                        DataHora = c.DateTime(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistrosMural", "Usuario_Id", "dbo.Usuarios");
            DropIndex("dbo.RegistrosMural", new[] { "Usuario_Id" });
            DropTable("dbo.RegistrosMural");
        }
    }
}
