namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoPacote : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacote",
                c => new
                    {
                        IdPacote = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        DescontoPacote = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantidadeDias = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPacote);
            
            AlterColumn("dbo.Opcional", "ValorDiaria", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Produtos", "ValorDiaria", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "ValorDiaria", c => c.Double(nullable: false));
            AlterColumn("dbo.Opcional", "ValorDiaria", c => c.Double(nullable: false));
            DropTable("dbo.Pacote");
        }
    }
}
