namespace Portaria.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blocos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Unidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        AparelhosGas = c.String(),
                        Observacoes = c.String(),
                        DataAtualizacao = c.DateTime(),
                        Animais = c.String(),
                        Assinaturas = c.String(),
                        Bloco_Id = c.Int(),
                        Conjuge_Id = c.Int(),
                        Locatario_Id = c.Int(),
                        Proprietario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blocos", t => t.Bloco_Id)
                .ForeignKey("dbo.Pessoas", t => t.Conjuge_Id)
                .ForeignKey("dbo.Pessoas", t => t.Locatario_Id)
                .ForeignKey("dbo.Pessoas", t => t.Proprietario_Id)
                .Index(t => t.Bloco_Id)
                .Index(t => t.Conjuge_Id)
                .Index(t => t.Locatario_Id)
                .Index(t => t.Proprietario_Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        RG = c.String(),
                        FoneResidencial = c.String(),
                        FoneComercial = c.String(),
                        FoneCelular = c.String(),
                        Email = c.String(),
                        GrauParentesco = c.String(),
                        Inadimplente = c.Boolean(nullable: false),
                        Foto = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegistrosLivroNegro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Mensagem = c.String(),
                        Pessoa_Id = c.Int(),
                        Sessao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id)
                .ForeignKey("dbo.Sessoes", t => t.Sessao_Id)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Sessao_Id);
            
            CreateTable(
                "dbo.RegistroLivroNegroEntidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEntidade = c.Int(nullable: false),
                        Tipo = c.String(),
                        RegistroLivroNegro_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RegistrosLivroNegro", t => t.RegistroLivroNegro_Id)
                .Index(t => t.RegistroLivroNegro_Id);
            
            CreateTable(
                "dbo.Sessoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHoraInicio = c.DateTime(),
                        DataHoraFim = c.DateTime(),
                        NomeEstacao = c.String(),
                        UsuarioLogado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioLogado_Id)
                .Index(t => t.UsuarioLogado_Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        DataHoraInicio = c.DateTime(nullable: false),
                        DataHoraFim = c.DateTime(nullable: false),
                        Local_Id = c.Int(),
                        Pessoa_Id = c.Int(),
                        Sessao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locais", t => t.Local_Id)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id)
                .ForeignKey("dbo.Sessoes", t => t.Sessao_Id)
                .Index(t => t.Local_Id)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Sessao_Id);
            
            CreateTable(
                "dbo.Locais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Foto = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                        Tipo = c.Int(nullable: false),
                        CorTema = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Placa = c.String(),
                        Cor = c.String(),
                        Foto = c.Binary(),
                        Proprietario_Id = c.Int(),
                        Unidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Proprietario_Id)
                .ForeignKey("dbo.Unidades", t => t.Unidade_Id)
                .Index(t => t.Proprietario_Id)
                .Index(t => t.Unidade_Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Fone = c.String(),
                        Descricao = c.String(),
                        Documento = c.String(),
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
            DropForeignKey("dbo.Unidades", "Proprietario_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Unidades", "Locatario_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Funcionarios", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Unidades", "Conjuge_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Unidades", "Bloco_Id", "dbo.Blocos");
            DropForeignKey("dbo.UnidadePessoas", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.UnidadePessoas", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Veiculo", "Unidade_Id", "dbo.Unidades");
            DropForeignKey("dbo.Veiculo", "Proprietario_Id", "dbo.Pessoas");
            DropForeignKey("dbo.RegistrosLivroNegro", "Sessao_Id", "dbo.Sessoes");
            DropForeignKey("dbo.Sessoes", "UsuarioLogado_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Reservas", "Sessao_Id", "dbo.Sessoes");
            DropForeignKey("dbo.Reservas", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Reservas", "Local_Id", "dbo.Locais");
            DropForeignKey("dbo.RegistrosLivroNegro", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.RegistroLivroNegroEntidades", "RegistroLivroNegro_Id", "dbo.RegistrosLivroNegro");
            DropIndex("dbo.UnidadePessoas", new[] { "Pessoa_Id" });
            DropIndex("dbo.UnidadePessoas", new[] { "Unidade_Id" });
            DropIndex("dbo.Funcionarios", new[] { "Unidade_Id" });
            DropIndex("dbo.Veiculo", new[] { "Unidade_Id" });
            DropIndex("dbo.Veiculo", new[] { "Proprietario_Id" });
            DropIndex("dbo.Reservas", new[] { "Sessao_Id" });
            DropIndex("dbo.Reservas", new[] { "Pessoa_Id" });
            DropIndex("dbo.Reservas", new[] { "Local_Id" });
            DropIndex("dbo.Sessoes", new[] { "UsuarioLogado_Id" });
            DropIndex("dbo.RegistroLivroNegroEntidades", new[] { "RegistroLivroNegro_Id" });
            DropIndex("dbo.RegistrosLivroNegro", new[] { "Sessao_Id" });
            DropIndex("dbo.RegistrosLivroNegro", new[] { "Pessoa_Id" });
            DropIndex("dbo.Unidades", new[] { "Proprietario_Id" });
            DropIndex("dbo.Unidades", new[] { "Locatario_Id" });
            DropIndex("dbo.Unidades", new[] { "Conjuge_Id" });
            DropIndex("dbo.Unidades", new[] { "Bloco_Id" });
            DropTable("dbo.UnidadePessoas");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Veiculo");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Locais");
            DropTable("dbo.Reservas");
            DropTable("dbo.Sessoes");
            DropTable("dbo.RegistroLivroNegroEntidades");
            DropTable("dbo.RegistrosLivroNegro");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Unidades");
            DropTable("dbo.Blocos");
        }
    }
}
