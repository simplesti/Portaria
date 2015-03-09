namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class posicaoAbas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "PosicaoAbas", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "PosicaoAbas");
        }
    }
}
