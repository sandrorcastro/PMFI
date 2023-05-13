
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey("EstadoId");
            builder.Property(tp => tp.EstadoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(100);
            builder.Property<string>("Sigla").HasMaxLength(5);
            builder.ToTable("Estado");
        }
    }
}
