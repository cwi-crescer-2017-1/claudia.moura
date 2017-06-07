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
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produtos");

            HasKey(x => x.IdProduto);

            Property(x => x.IdProduto)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Console).IsRequired();
            Property(p => p.ValorDiaria).IsRequired(); ;
            Property(p => p.Quantidade).IsRequired();
        }
    }
}