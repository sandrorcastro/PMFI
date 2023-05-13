using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.HasKey("TipoDocumentoId");
            builder.Property(tp => tp.TipoDocumentoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(15); //.IsRequired();
            builder.ToTable("TipoDocumento");
            
        }
    }
}
