namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 140),
                        Endereco = c.String(maxLength: 200),
                        CPF = c.String(nullable: false, maxLength: 11),
                        Genero = c.String(nullable: false, maxLength: 2),
                        DataNascimento = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
