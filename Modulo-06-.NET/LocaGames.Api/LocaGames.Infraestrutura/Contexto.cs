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
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
        }
    }
}
