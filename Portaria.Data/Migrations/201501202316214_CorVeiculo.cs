namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorVeiculo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculo", "Cor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculo", "Cor");
        }
    }
}
