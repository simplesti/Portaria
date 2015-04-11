namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BiometriaFuncionario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "Biometria", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "Biometria");
        }
    }
}
