using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
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

            HasKey(x => x.IdCliente);

            Property(x => x.IdCliente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).IsRequired().HasMaxLength(200);
            Property(p => p.Endereco).HasMaxLength(200); 
            Property(p => p.Genero).IsRequired().HasMaxLength(2);
            Property(p => p.CPF).IsRequired().HasMaxLength(11);
        }
    }
}
