using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class SituacaoProcessoConfiguration : IEntityTypeConfiguration<SituacaoProcesso>
    {
        public void Configure(EntityTypeBuilder<SituacaoProcesso> builder)
        {
            builder.HasKey("SituacaoProcessoId");
            builder.Property(tp => tp.SituacaoProcessoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(100);
            builder.ToTable("SituacaoProcesso");
            builder.HasData(new SituacaoProcesso
            {
                SituacaoProcessoId = 1,
                Descricao = "Iniciado",

            }, new SituacaoProcesso
            {
                SituacaoProcessoId = 2,
                Descricao = "Finalizado",

            }
            );
        }
    }
}
