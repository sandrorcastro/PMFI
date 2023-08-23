


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMFI.Domain.Entities;
using System.Reflection.Emit;

namespace PMFI.Infra.EntityConfig
{
    public class UfConfiguration : IEntityTypeConfiguration<Uf>
    {
        public void Configure(EntityTypeBuilder<Uf> builder)
        {
            builder.HasKey(e => e.IdUf).HasName("pk_uf");
            builder.ToTable("uf");
            builder.HasIndex(e => e.IdPais, "fk_uf_pais");
            builder.Property(e => e.IdUf).ValueGeneratedNever().HasColumnName("id_uf");
            builder.Property(e => e.CodigoIbge).HasColumnName("codigo_ibge");
            builder.Property(e => e.IdPais).HasColumnName("id_pais");
            builder.Property(e => e.Nome).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
            builder.Property(e => e.Sigla).HasMaxLength(2).IsUnicode(false).HasColumnName("sigla").IsFixedLength();
            builder.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Ufs).HasForeignKey(d => d.IdPais).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_uf_pais");
        }
    }
}
