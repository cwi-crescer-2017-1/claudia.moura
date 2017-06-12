namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoOpcionais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Opcional",
                c => new
                    {
                        IdOpcional = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        ValorDiaria = c.Double(nullable: false),
                        QuantidadeTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOpcional);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Opcional");
        }
    }
}
