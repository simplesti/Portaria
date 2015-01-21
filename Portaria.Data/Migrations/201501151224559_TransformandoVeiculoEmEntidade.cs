namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransformandoVeiculoEmEntidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Placa = c.String(),
                        Proprietario_Id = c.Int(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Proprietario_Id)
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id)
                .Index(t => t.Proprietario_Id)
                .Index(t => t.Unidade_Id);
            
            DropColumn("dbo.Unidades", "Veiculos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Unidades", "Veiculos", c => c.String());
            DropForeignKey("dbo.Veiculo", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Veiculo", "Proprietario_Id", "dbo.Pessoas");
            DropIndex("dbo.Veiculo", new[] { "Unidade_Id" });
            DropIndex("dbo.Veiculo", new[] { "Proprietario_Id" });
            DropTable("dbo.Veiculo");
        }
    }
}
