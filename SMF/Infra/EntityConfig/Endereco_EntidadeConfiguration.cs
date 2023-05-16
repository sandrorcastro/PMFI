﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class Endereco_EntidadeConfiguration : IEntityTypeConfiguration<Endereco_Entidade>
    {
        public void Configure(EntityTypeBuilder<Endereco_Entidade> builder)
        {
            builder.HasKey(sc => new { sc.EntidadeId, sc.EnderecoId, sc.TipoEntidadeId,sc.Numero});
            builder.Property(ep => ep.EntidadeId).ValueGeneratedNever();
            builder.Property(ep => ep.EnderecoId).ValueGeneratedNever();
            builder.Property<string>("Numero").HasMaxLength(10); //.IsRequired();
            builder.Property<string>("CEP").HasMaxLength(10); //.IsRequired();
            builder.Property(p => p.DataCadastro).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property<bool?>("Ativo").HasDefaultValue(true);
            builder.Property<bool?>("Principal").HasDefaultValue(false);
            builder.Property<bool?>("Correspondencia").HasDefaultValue(false);
            // builder.Property(p => p.DataUltimaAlteracao).HasDefaultValueSql(null).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.ToTable("Endereco_Entidade");
            
        }
    }
}