namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoLocacao : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Locacao", "TotalOpcionais");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locacao", "TotalOpcionais", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
