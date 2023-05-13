using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class RegiaoConfiguration : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey("RegiaoId");
            builder.Property(tp => tp.RegiaoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(500).IsRequired();
            builder.Property<string>("CentroGrauLon").HasMaxLength(50);
            builder.Property<string>("CentroGrauLat").HasMaxLength(50);
            builder.ToTable("Regiao");
            
        }
    }
}
