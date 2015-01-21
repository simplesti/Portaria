namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inadimplencia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Inadimplente", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "Inadimplente");
        }
    }
}
