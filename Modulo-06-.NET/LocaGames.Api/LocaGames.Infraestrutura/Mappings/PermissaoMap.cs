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
    public class PermissaoMap : EntityTypeConfiguration<Permissao>
    {

        public PermissaoMap() 
        {
            HasKey(x => x.IdPermissao);

            Property(p => p.Nome).IsRequired();
            Property(x => x.IdPermissao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}

