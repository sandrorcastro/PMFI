using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TipoResponsabilidadeConfiguration : IEntityTypeConfiguration<TipoResponsabilidade>
    {
        public void Configure(EntityTypeBuilder<TipoResponsabilidade> builder)
        {
            builder.HasKey("TipoResponsabilidadeId");
            builder.Property(tp => tp.TipoResponsabilidadeId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(50);
            builder.ToTable("TipoResponsabilidade");
            builder.HasData(new TipoResponsabilidade
            {
                TipoResponsabilidadeId = 1,
                Descricao = "Proprietário",

            }, new TipoResponsabilidade
            {
                TipoResponsabilidadeId = 2,
                Descricao = "Responsável",

            }, new TipoResponsabilidade
            {
                TipoResponsabilidadeId = 3,
                Descricao = "Co-Responsável",

            }
            );
        }
    }
}
