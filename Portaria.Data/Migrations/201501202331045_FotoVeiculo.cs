namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FotoVeiculo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculo", "Foto", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculo", "Foto");
        }
    }
}
