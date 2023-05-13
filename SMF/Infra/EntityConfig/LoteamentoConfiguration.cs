using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class LoteamentoConfiguration : IEntityTypeConfiguration<Loteamento>
    {
        public void Configure(EntityTypeBuilder<Loteamento> builder)
        {
            builder.HasKey("LoteamentoId");
            builder.Property(tp => tp.LoteamentoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(200); //.IsRequired();
            builder.ToTable("Loteamento");
        }
    }
}
