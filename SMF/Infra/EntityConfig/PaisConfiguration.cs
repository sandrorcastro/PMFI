using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{ 
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.HasKey("PaisId");
            builder.Property(p => p.PaisId).ValueGeneratedNever();
            builder.Property<string>("Nome").HasMaxLength(200).IsRequired();
            builder.Property<string>("Sigla").HasMaxLength(15).IsRequired();
            builder.ToTable("Pais");
            
        }
    }
}
