namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id)
                .Index(t => t.Unidade_Id);
            
            CreateTable(
                "dbo.Unidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Bloco = c.String(),
                        AparelhosGas = c.String(),
                        Observacoes = c.String(),
                        DataAtualizacao = c.DateTime(),
                        Conjuge_Id = c.Int(),
                        Proprietario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Conjuge_Id)
                .ForeignKey("dbo.Pessoas", t => t.Proprietario_Id)
                .Index(t => t.Conjuge_Id)
                .Index(t => t.Proprietario_Id);
            
            CreateTable(
                "dbo.Assinaturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Frequencia = c.String(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id)
                .Index(t => t.Unidade_Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        FoneResidencial = c.String(),
                        FoneComercial = c.String(),
                        FoneCelular = c.String(),
                        Email = c.String(),
                        GrauParentesco = c.String(),
                        Foto = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Fone = c.String(),
                        Descricao = c.String(),
                        AutorizadaSemPresenca = c.Boolean(nullable: false),
                        Frequencia = c.String(),
                        HorarioEntrada = c.DateTime(),
                        HorarioSaida = c.DateTime(),
                        Foto = c.Binary(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id)
                .Index(t => t.Unidade_Id);
            
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        Marca = c.String(),
                        Placa = c.String(),
                        Cor = c.String(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id)
                .Index(t => t.Unidade_Id);
            
            CreateTable(
                "dbo.UnidadePessoas",
                c => new
                    {
                        Unidade_Id = c.Int(nullable: false),
                        Pessoa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Unidade_Id, t.Pessoa_Id })
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id, cascadeDelete: true)
                .Index(t => t.Unidade_Id)
                .Index(t => t.Pessoa_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculos", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Unidades", "Proprietario_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Funcionarios", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Unidades", "Conjuge_Id", "dbo.Pessoas");
            DropForeignKey("dbo.UnidadePessoas", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.UnidadePessoas", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Assinaturas", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Animais", "Unidade_Id", "dbo.Unidades");
            DropIndex("dbo.UnidadePessoas", new[] { "Pessoa_Id" });
            DropIndex("dbo.UnidadePessoas", new[] { "Unidade_Id" });
            DropIndex("dbo.Veiculos", new[] { "Unidade_Id" });
            DropIndex("dbo.Funcionarios", new[] { "Unidade_Id" });
            DropIndex("dbo.Assinaturas", new[] { "Unidade_Id" });
            DropIndex("dbo.Unidades", new[] { "Proprietario_Id" });
            DropIndex("dbo.Unidades", new[] { "Conjuge_Id" });
            DropIndex("dbo.Animais", new[] { "Unidade_Id" });
            DropTable("dbo.UnidadePessoas");
            DropTable("dbo.Veiculos");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Assinaturas");
            DropTable("dbo.Unidades");
            DropTable("dbo.Animais");
        }
    }
}
