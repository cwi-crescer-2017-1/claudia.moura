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
    public class LocacaoMap : EntityTypeConfiguration<Locacao>
    {

        public LocacaoMap()
        {
            ToTable("Locacao");

            HasKey(x => x.IdLocacao);

            Property(x => x.IdLocacao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Console)
                .WithMany()
                .Map(x => x.MapKey("IdProduto"));

            HasRequired(x => x.Pacote)
                .WithMany()
                .Map(x => x.MapKey("IdPacote"));

            HasRequired(x => x.Cliente)
                .WithMany()
                .Map(x => x.MapKey("IdCliente"));

            Property(p => p.ValorDiario).IsOptional();
            Property(p => p.ValorTotal).IsOptional();
           // Property(p => p.TotalOpcionais).IsOptional();
            Property(p => p.ValorPago).IsOptional();
            Property(p => p.DataLocacao).IsOptional();
            Property(p => p.DataDevolucao).IsOptional();
            Property(p => p.DataDevolucaoReal).IsOptional();
            Property(p => p.DiasAtrasados).IsOptional();
            Property(p => p.DataDevolucao).IsOptional();


        }

    }

}