
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Models;

namespace MVC.EntityConfig
{
    public class EconomiaConfiguration : IEntityTypeConfiguration<Economia>
    {
        public void Configure(EntityTypeBuilder<Economia> builder)
        {
            builder.HasKey(e => new { e.ImovelId, e.EconomiaId }); //.HasName("ImovelId_EconomiaID");
            builder.Property(e => e.ImovelId).ValueGeneratedNever();
            builder.Property(e => e.EconomiaId).ValueGeneratedNever();
            builder.ToTable("Economia");
        }
    }
}
