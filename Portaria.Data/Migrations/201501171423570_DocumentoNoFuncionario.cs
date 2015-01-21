namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentoNoFuncionario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "Documento", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "Documento");
        }
    }
}
