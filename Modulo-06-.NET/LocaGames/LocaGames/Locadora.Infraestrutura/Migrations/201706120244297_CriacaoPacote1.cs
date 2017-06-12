namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoPacote1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtos", newName: "Produto");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produto", newName: "Produtos");
        }
    }
}
