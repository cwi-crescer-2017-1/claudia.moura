namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        Console = c.String(nullable: false),
                        ValorDiaria = c.Double(nullable: false),
                        QuantidadeProduto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
