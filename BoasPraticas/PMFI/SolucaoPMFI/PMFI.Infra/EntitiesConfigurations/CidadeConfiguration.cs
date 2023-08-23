


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMFI.Domain.Entities;
using System.Reflection.Emit;

namespace PMFI.Infra.EntityConfig
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(e => e.IdCidade).HasName("pk_cidade");
            builder.ToTable("cidade");
            builder.HasIndex(e => new { e.IdUf, e.Nome }, "ak1_cidade").IsUnique();
            builder.HasIndex(e => e.IdPais, "fk_cidade_pais");
            builder.HasIndex(e => e.IdUf, "fk_cidade_uf");
            builder.HasIndex(e => new { e.IdPais, e.IdUf, e.SinCapital, e.CodigoIbge }, "i01_cidade");
            builder.Property(e => e.IdCidade).ValueGeneratedNever().HasColumnName("id_cidade");
            builder.Property(e => e.CodigoIbge).HasColumnName("codigo_ibge");
            builder.Property(e => e.IdPais).HasColumnName("id_pais");
            builder.Property(e => e.IdUf).HasColumnName("id_uf");
            builder.Property(e => e.Latitude).HasColumnType("numeric(9, 6)").HasColumnName("latitude");
            builder.Property(e => e.Longitude).HasColumnType("numeric(9, 6)").HasColumnName("longitude");
            builder.Property(e => e.Nome).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
            builder.Property(e => e.SinCapital).HasMaxLength(1).IsUnicode(false).HasColumnName("sin_capital").IsFixedLength();
            builder.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Cidades).HasForeignKey(d => d.IdPais).HasConstraintName("fk_cidade_pais");
            builder.HasOne(d => d.IdUfNavigation).WithMany(p => p.Cidades).HasForeignKey(d => d.IdUf).HasConstraintName("fk_cidade_uf");
        }
    }
}
