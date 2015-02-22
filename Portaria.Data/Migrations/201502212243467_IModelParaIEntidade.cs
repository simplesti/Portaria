namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IModelParaIEntidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegistroLivroNegroEntidades", "IdEntidade", c => c.Int(nullable: false));
            DropColumn("dbo.RegistroLivroNegroEntidades", "IdModelo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RegistroLivroNegroEntidades", "IdModelo", c => c.Int(nullable: false));
            DropColumn("dbo.RegistroLivroNegroEntidades", "IdEntidade");
        }
    }
}
