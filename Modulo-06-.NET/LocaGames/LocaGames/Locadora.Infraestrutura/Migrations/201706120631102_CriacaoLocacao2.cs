namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoLocacao2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locacao", "IdPacote", "dbo.Pacote");
            DropIndex("dbo.Locacao", new[] { "IdPacote" });
            AlterColumn("dbo.Locacao", "ValorDiario", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Locacao", "ValorTotal", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Locacao", "TotalOpcionais", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Locacao", "ValorPago", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Locacao", "DataLocacao", c => c.DateTime());
            AlterColumn("dbo.Locacao", "DataDevolucao", c => c.DateTime());
            AlterColumn("dbo.Locacao", "DataDevolucaoReal", c => c.DateTime());
            AlterColumn("dbo.Locacao", "DiasAtrasados", c => c.Int());
            AlterColumn("dbo.Locacao", "IdPacote", c => c.Int(nullable: false));
            CreateIndex("dbo.Locacao", "IdPacote");
            AddForeignKey("dbo.Locacao", "IdPacote", "dbo.Pacote", "IdPacote", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacao", "IdPacote", "dbo.Pacote");
            DropIndex("dbo.Locacao", new[] { "IdPacote" });
            AlterColumn("dbo.Locacao", "IdPacote", c => c.Int());
            AlterColumn("dbo.Locacao", "DiasAtrasados", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "DataDevolucaoReal", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "DataDevolucao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "DataLocacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "ValorPago", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Locacao", "TotalOpcionais", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Locacao", "ValorTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Locacao", "ValorDiario", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Locacao", "IdPacote");
            AddForeignKey("dbo.Locacao", "IdPacote", "dbo.Pacote", "IdPacote");
        }
    }
}
