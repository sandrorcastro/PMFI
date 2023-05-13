using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(c => new { c.CidadeId });
            builder.Property(tp => tp.CidadeId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(500).IsRequired();
            builder.ToTable("Cidade");
            
        }
    }
}
