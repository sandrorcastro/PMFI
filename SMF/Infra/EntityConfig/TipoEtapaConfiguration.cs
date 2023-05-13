using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TipoEtapaConfiguration : IEntityTypeConfiguration<TipoEtapa>
    {
        public void Configure(EntityTypeBuilder<TipoEtapa> builder)
        {
            builder.HasKey("TipoEtapaId");
            builder.Property(tp => tp.TipoEtapaId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(60); //.IsRequired();
            builder.Property<string>("Lei").HasMaxLength(50); //.IsRequired();
            builder.ToTable("TipoEtapa");
            
        }
    }
}
