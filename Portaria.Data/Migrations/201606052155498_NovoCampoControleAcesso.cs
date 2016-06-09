namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovoCampoControleAcesso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "ControleAcessoAutorizado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "ControleAcessoAutorizado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Funcionarios", "ControleAcessoAutorizado", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Usuarios", "Nome", c => c.String());
            AlterColumn("dbo.Usuarios", "CPF", c => c.String());
            AlterColumn("dbo.Usuarios", "RG", c => c.String());
            AlterColumn("dbo.Usuarios", "Login", c => c.String());
            AlterColumn("dbo.Usuarios", "Senha", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Login", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "RG", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "CPF", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(nullable: false));
            DropColumn("dbo.Funcionarios", "ControleAcessoAutorizado");
            DropColumn("dbo.Usuarios", "ControleAcessoAutorizado");
            DropColumn("dbo.Pessoas", "ControleAcessoAutorizado");
        }
    }
}
