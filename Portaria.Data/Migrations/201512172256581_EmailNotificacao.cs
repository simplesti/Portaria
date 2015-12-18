namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailNotificacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CategoriasLivroNegro", "EnviarEmailNotificacao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CategoriasLivroNegro", "EnviarEmailNotificacao");
        }
    }
}
