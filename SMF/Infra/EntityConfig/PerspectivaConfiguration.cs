using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class PerspectivaConfiguration : IEntityTypeConfiguration<Perspectiva>
    {
        public void Configure(EntityTypeBuilder<Perspectiva> builder)
        {
            builder.HasKey("PerspectivaId");
            builder.Property(tp => tp.PerspectivaId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(50);
            builder.ToTable("Perspectiva");
            builder.HasData(new Perspectiva
            {
                PerspectivaId = 1,
                Descricao = "Frontal",

            }, new Perspectiva
            {
                PerspectivaId = 2,
                Descricao = "Lateral Direita",

            }, new Perspectiva
            {
                PerspectivaId = 3,
                Descricao = "Lateral Esquerda",

            }, new Perspectiva
            {
                PerspectivaId = 4,
                Descricao = "Fundo",
            }
            );
        }
    }
}
