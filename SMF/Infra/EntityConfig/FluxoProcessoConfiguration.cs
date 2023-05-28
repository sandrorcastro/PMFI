using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class FluxoProcessoConfiguration : IEntityTypeConfiguration<FluxoProcesso>
    {
        public void Configure(EntityTypeBuilder<FluxoProcesso> builder)
        {
            builder.HasKey(fp=> new { fp.FluxoProcessoId,fp.TipoProcessoId });
            builder.Property(tp => tp.FluxoProcessoId).ValueGeneratedNever();
            builder.Property(tp => tp.TipoProcessoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(50);
            //builder.HasMany(e=>e.Etapas).WithOne(fp=>fp.FluxoProcesso).HasForeignKey()
            builder.ToTable("FluxoProcesso");
            
        }
    }
}
