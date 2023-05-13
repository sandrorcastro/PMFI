using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class ContatoConfiguration : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => new { c.ContatoId });
            builder.Property(tp => tp.ContatoId).ValueGeneratedNever();
            builder.ToTable("Contato");
            
        }
    }
}
