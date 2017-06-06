using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Clientes");

            Property(p => p.Nome).HasMaxLength(300);
        }
    }
}
