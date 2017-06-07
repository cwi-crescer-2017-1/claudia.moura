namespace LocaGames.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Endereco = c.String(maxLength: 200),
                        CPF = c.String(nullable: false, maxLength: 11),
                        Genero = c.String(nullable: false, maxLength: 2),
                        DataNascimento = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        IdFuncionario = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdFuncionario);
            
            CreateTable(
                "dbo.Permissaos",
                c => new
                    {
                        IdPermissao = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Funcionario_IdFuncionario = c.Guid(),
                    })
                .PrimaryKey(t => t.IdPermissao)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_IdFuncionario)
                .Index(t => t.Funcionario_IdFuncionario);
            
            CreateTable(
                "dbo.Locacoes",
                c => new
                    {
                        IdLocacao = c.Int(nullable: false, identity: true),
                        ValorTotal = c.Double(nullable: false),
                        Data = c.DateTime(),
                        IdCliente = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        IdPacote = c.Int(),
                    })
                .PrimaryKey(t => t.IdLocacao)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.IdProduto, cascadeDelete: true)
                .ForeignKey("dbo.Pacotes", t => t.IdPacote)
                .Index(t => t.IdCliente)
                .Index(t => t.IdProduto)
                .Index(t => t.IdPacote);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        Console = c.String(nullable: false),
                        ValorDiaria = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduto);
            
            CreateTable(
                "dbo.LocacaoOpcional",
                c => new
                    {
                        IdLocacaoOpcional = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        IdLocacao = c.Int(nullable: false),
                        IdOpcional = c.Int(),
                        Locacao_IdLocacao1 = c.Int(),
                    })
                .PrimaryKey(t => t.IdLocacaoOpcional)
                .ForeignKey("dbo.Locacoes", t => t.IdLocacao, cascadeDelete: true)
                .ForeignKey("dbo.Opcionais", t => t.IdOpcional)
                .ForeignKey("dbo.Locacoes", t => t.Locacao_IdLocacao1)
                .Index(t => t.IdLocacao)
                .Index(t => t.IdOpcional)
                .Index(t => t.Locacao_IdLocacao1);
            
            CreateTable(
                "dbo.Opcionais",
                c => new
                    {
                        IdOpcional = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        ValorDiaria = c.Double(nullable: false),
                        QuantidadeTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOpcional);
            
            CreateTable(
                "dbo.Pacotes",
                c => new
                    {
                        IdPacote = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        DescontoPacote = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdPacote);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacoes", "IdPacote", "dbo.Pacotes");
            DropForeignKey("dbo.LocacaoOpcional", "Locacao_IdLocacao1", "dbo.Locacoes");
            DropForeignKey("dbo.LocacaoOpcional", "IdOpcional", "dbo.Opcionais");
            DropForeignKey("dbo.LocacaoOpcional", "IdLocacao", "dbo.Locacoes");
            DropForeignKey("dbo.Locacoes", "IdProduto", "dbo.Produtos");
            DropForeignKey("dbo.Locacoes", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Permissaos", "Funcionario_IdFuncionario", "dbo.Funcionarios");
            DropIndex("dbo.LocacaoOpcional", new[] { "Locacao_IdLocacao1" });
            DropIndex("dbo.LocacaoOpcional", new[] { "IdOpcional" });
            DropIndex("dbo.LocacaoOpcional", new[] { "IdLocacao" });
            DropIndex("dbo.Locacoes", new[] { "IdPacote" });
            DropIndex("dbo.Locacoes", new[] { "IdProduto" });
            DropIndex("dbo.Locacoes", new[] { "IdCliente" });
            DropIndex("dbo.Permissaos", new[] { "Funcionario_IdFuncionario" });
            DropTable("dbo.Pacotes");
            DropTable("dbo.Opcionais");
            DropTable("dbo.LocacaoOpcional");
            DropTable("dbo.Produtos");
            DropTable("dbo.Locacoes");
            DropTable("dbo.Permissaos");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Clientes");
        }
    }
}
