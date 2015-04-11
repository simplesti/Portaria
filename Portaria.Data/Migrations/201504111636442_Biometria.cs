namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Biometria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Biometria", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "Biometria");
        }
    }
}
