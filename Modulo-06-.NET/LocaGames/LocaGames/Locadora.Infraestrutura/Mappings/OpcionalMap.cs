using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Mappings
{
    public class OpcionalMap : EntityTypeConfiguration<Opcional>
    {

        public OpcionalMap()
        {
            ToTable("Opcional");

            HasKey(x => x.IdOpcional);

            Property(x => x.IdOpcional)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).IsRequired();
            Property(p => p.ValorDiaria).IsRequired();
            Property(p => p.QuantidadeTotal).IsRequired();

        }
    }
}
