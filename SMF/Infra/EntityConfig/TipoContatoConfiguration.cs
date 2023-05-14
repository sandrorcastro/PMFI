using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TipoContatoConfiguration : IEntityTypeConfiguration<TipoContato>
    {
        public void Configure(EntityTypeBuilder<TipoContato> builder)
        {
            builder.HasKey("TipoContatoId");
            builder.Property(tp => tp.TipoContatoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(50); //.IsRequired();
            builder.ToTable("TipoContato");
            
        }
    }
}
