
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class BairroConfiguration : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.HasKey("BairroId");
            builder.Property(tp => tp.BairroId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(150); 
            builder.ToTable("Bairro");
        }
    }
}
