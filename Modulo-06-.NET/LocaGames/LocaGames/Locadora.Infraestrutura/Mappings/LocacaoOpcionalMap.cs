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
    class LocacaoOpcionalMap : EntityTypeConfiguration<LocacaoOpcional>
    {
        public LocacaoOpcionalMap()
        {
            ToTable("LocacaoOpcional");

            HasKey(x => x.IdLocacaoOpcional);

            Property(x => x.IdLocacaoOpcional)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Quantidade).IsRequired();

            HasRequired(x => x.Locacao)
                .WithMany()
                .Map(x => x.MapKey("IdLocacao"));

            HasOptional(x => x.Opcional)
                .WithMany()
                .Map(x => x.MapKey("IdOpcional"));
        }
    }
}
