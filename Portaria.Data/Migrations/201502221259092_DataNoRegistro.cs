namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataNoRegistro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegistrosLivroNegro", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegistrosLivroNegro", "Data");
        }
    }
}
