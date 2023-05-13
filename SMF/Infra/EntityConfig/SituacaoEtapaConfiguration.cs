using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class SituacaoEtapaConfiguration : IEntityTypeConfiguration<SituacaoEtapa>
    {
        public void Configure(EntityTypeBuilder<SituacaoEtapa> builder)
        {
            builder.HasKey("SituacaoEtapaId");
            builder.Property(tp => tp.SituacaoEtapaId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(100);
            builder.ToTable("SituacaoEtapa");
            builder.HasData(new SituacaoEtapa
            {
                SituacaoEtapaId = 1,
                Descricao = "Iniciado",

            }, new SituacaoEtapa
            {
                SituacaoEtapaId = 2,
                Descricao = "Finalizado",

            }, new SituacaoEtapa
            {
                SituacaoEtapaId = 3,
                Descricao = "Trâmite",
            } 
            );
        }
    }
}
