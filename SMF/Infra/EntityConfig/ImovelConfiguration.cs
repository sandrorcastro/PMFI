using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class ImovelConfiguration : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.HasKey("ImovelId");
            
            builder.Property(tp => tp.ImovelId).ValueGeneratedNever();
            builder.Property<string>("Complemento").HasMaxLength(500); //.IsRequired();
        //    builder.Property<string>("EdificacaoIdTemp").HasMaxLength(50); //.IsRequired();
        //    builder.Property<string>("TerrenoIdTemp").HasMaxLength(50);
            builder.Property<string>("Latitude").HasMaxLength(50);
            builder.Property<string>("Longitude").HasMaxLength(50);
            builder.Property<string>("AreaTerreno").HasMaxLength(50);
            builder.Property<string>("AreaConstruida").HasMaxLength(50);
            builder.Property<string>("AnoConstrucao").HasMaxLength(50);
            builder.Property<string>("Caracteristica").HasMaxLength(50);
            builder.Property<string>("Matricula").HasMaxLength(20);
            

            // builder.Property<string>("Referencia").HasMaxLength(500); //.IsRequired();
            // builder.Property<string>("CEP").HasMaxLength(15); //.IsRequired();

            builder.ToTable("Imovel");
            
        }
    }
}
