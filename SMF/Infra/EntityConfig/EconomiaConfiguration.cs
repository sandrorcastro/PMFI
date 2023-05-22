using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class EconomiaConfiguration : IEntityTypeConfiguration<Economia>
    {
        public void Configure(EntityTypeBuilder<Economia> builder)
        {
            /////builder.HasKey(e => new {e.ImovelId, e.EconomiaId } ); //.HasName("ImovelId_EconomiaID");
            builder.HasKey(e => new { e.ImovelId, e.EconomiaId }); //.HasName("ImovelId_EconomiaID");
            //builder.HasMany(e=>e.Enderecos).WithOne().HasPrincipalKey(e=> new { e.ImovelId, e.EconomiaId}).HasForeignKey(ee=> new { ee.ImovelId, ee.EconomiaId });











            // builder.HasOne(i => i.Imovel).WithMany().HasForeignKey(i=>new { i.ImovelId, i.EconomiaId});
            builder.Property(e => e.ImovelId).ValueGeneratedNever();
            builder.Property(e => e.EconomiaId).ValueGeneratedNever();
            builder.Property<string>("Complemento").HasMaxLength(500); //.IsRequired();
            //builder.Property<string>("EdificacaoIdTemp").HasMaxLength(50); //.IsRequired();
            builder.Property<string>("TerrenoIdTemp").HasMaxLength(50);
            builder.Property<string>("Latitude").HasMaxLength(50);
            builder.Property<string>("Longitude").HasMaxLength(50);
            builder.Property<string>("AreaConstruida").HasMaxLength(50);
            builder.Property<string>("AnoConstrucao").HasMaxLength(50);
            builder.Property<string>("Caracteristica").HasMaxLength(50);
            builder.ToTable("Economia");
            
        }
    }
}
