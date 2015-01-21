namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CPFeRG : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "CPF", c => c.String());
            AddColumn("dbo.Pessoas", "RG", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "RG");
            DropColumn("dbo.Pessoas", "CPF");
        }
    }
}
