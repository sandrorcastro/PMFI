using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TipoProcessoConfiguration : IEntityTypeConfiguration<TipoProcesso>
    {
        public void Configure(EntityTypeBuilder<TipoProcesso> builder)
        {
            builder.HasKey("TipoProcessoId");
            builder.Property(tp => tp.TipoProcessoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(100); //.IsRequired();
            builder.ToTable("TipoProcesso");
            
        }
    }
}
