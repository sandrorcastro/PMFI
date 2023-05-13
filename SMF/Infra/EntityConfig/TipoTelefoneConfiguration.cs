using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TipoTelefoneConfiguration : IEntityTypeConfiguration<TipoTelefone>
    {
        public void Configure(EntityTypeBuilder<TipoTelefone> builder)
        {
            builder.HasKey("TipoTelefoneId");
            builder.Property(tp => tp.TipoTelefoneId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(15); //.IsRequired();
            builder.ToTable("TipoTelefone");
            
        }
    }
}
