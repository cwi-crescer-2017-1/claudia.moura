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
    public class OpcionalMap : EntityTypeConfiguration<Opcional>
    {
        public OpcionalMap()
        {
            ToTable("Opcionais");

            HasKey(x => x.IdOpcional);

            Property(x => x.IdOpcional)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).IsRequired();
            Property(p => p.ValorDiaria).IsRequired();
            Property(p => p.QuantidadeTotal).IsRequired();

        }
    }
}