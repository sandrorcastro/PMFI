


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMFI.Domain.Entities;
using System.Reflection.Emit;

namespace PMFI.Infra.EntityConfig
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            
                builder.HasKey(e => e.IdPais).HasName("pk_pais");
                builder.ToTable("pais");
                builder.Property(e => e.IdPais).ValueGeneratedNever().HasColumnName("id_pais");
                builder.Property(e => e.Nome).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
            

        }
    }
}
