using LocaGames.Dominio;
using LocaGames.Infraestrutura.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=LocaGames")
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Opcional> Opcionais { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Produto> Produtos { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new LocacaoMap());
            modelBuilder.Configurations.Add(new LocacaoOpcionalMap());
            modelBuilder.Configurations.Add(new OpcionalMap());
            modelBuilder.Configurations.Add(new PacoteMap());
            modelBuilder.Configurations.Add(new PermissaoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
        }
    }
}
