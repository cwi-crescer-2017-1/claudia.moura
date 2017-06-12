namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoLocacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        IdLocacao = c.Int(nullable: false, identity: true),
                        ValorDiario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalOpcionais = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPago = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataLocacao = c.DateTime(nullable: false),
                        DataDevolucao = c.DateTime(nullable: false),
                        DataDevolucaoReal = c.DateTime(nullable: false),
                        DiasAtrasados = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        IdPacote = c.Int(),
                    })
                .PrimaryKey(t => t.IdLocacao)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.IdProduto, cascadeDelete: true)
                .ForeignKey("dbo.Pacote", t => t.IdPacote)
                .Index(t => t.IdCliente)
                .Index(t => t.IdProduto)
                .Index(t => t.IdPacote);
            
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
                .ForeignKey("dbo.Locacao", t => t.IdLocacao, cascadeDelete: true)
                .ForeignKey("dbo.Opcional", t => t.IdOpcional)
                .ForeignKey("dbo.Locacao", t => t.Locacao_IdLocacao1)
                .Index(t => t.IdLocacao)
                .Index(t => t.IdOpcional)
                .Index(t => t.Locacao_IdLocacao1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacao", "IdPacote", "dbo.Pacote");
            DropForeignKey("dbo.LocacaoOpcional", "Locacao_IdLocacao1", "dbo.Locacao");
            DropForeignKey("dbo.LocacaoOpcional", "IdOpcional", "dbo.Opcional");
            DropForeignKey("dbo.LocacaoOpcional", "IdLocacao", "dbo.Locacao");
            DropForeignKey("dbo.Locacao", "IdProduto", "dbo.Produto");
            DropForeignKey("dbo.Locacao", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.LocacaoOpcional", new[] { "Locacao_IdLocacao1" });
            DropIndex("dbo.LocacaoOpcional", new[] { "IdOpcional" });
            DropIndex("dbo.LocacaoOpcional", new[] { "IdLocacao" });
            DropIndex("dbo.Locacao", new[] { "IdPacote" });
            DropIndex("dbo.Locacao", new[] { "IdProduto" });
            DropIndex("dbo.Locacao", new[] { "IdCliente" });
            DropTable("dbo.LocacaoOpcional");
            DropTable("dbo.Locacao");
        }
    }
}
