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
    public class PacoteMap : EntityTypeConfiguration<Pacote>
    {

        public PacoteMap()
        {
            ToTable("Pacote");

            HasKey(x => x.IdPacote);

            Property(x => x.IdPacote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome).IsRequired();
            Property(p => p.QuantidadeDias).IsRequired();
            Property(p => p.DescontoPacote).IsRequired();

        }        
    }
}