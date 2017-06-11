namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacaoCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "DataNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "DataNascimento", c => c.DateTime());
        }
    }
}
