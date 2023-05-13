using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TelefoneConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            //builder.HasKey("TelefoneId");
            //builder.Property(tp => tp.TelefoneId).ValueGeneratedNever();
            builder.Property<string>("Numero").HasMaxLength(15).IsRequired();
            builder.ToTable("Telefone");
            
        }
    }
}
