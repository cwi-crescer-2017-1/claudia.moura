﻿using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Mappings
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("Funcionarios");

            HasKey(x => x.IdFuncionario);
            Property(x => x.IdFuncionario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome).IsRequired().HasMaxLength(100);
            Property(p => p.Email).IsRequired(); 
            Property(p => p.Senha).IsRequired();
        }
    }
}
