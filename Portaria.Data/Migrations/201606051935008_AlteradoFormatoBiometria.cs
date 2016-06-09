namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteradoFormatoBiometria : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Biometria", c => c.String());
            AlterColumn("dbo.Usuarios", "Biometria", c => c.String());
            AlterColumn("dbo.Funcionarios", "Biometria", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Funcionarios", "Biometria", c => c.Binary());
            AlterColumn("dbo.Usuarios", "Biometria", c => c.Binary());
            AlterColumn("dbo.Pessoas", "Biometria", c => c.Binary());
        }
    }
}
