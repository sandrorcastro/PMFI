using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{ 
    public class DDDConfiguration : IEntityTypeConfiguration<DDD>
    {
        public void Configure(EntityTypeBuilder<DDD> builder)
        {
            builder.HasKey("DDDId");
            builder.Property(tp => tp.DDDId).ValueGeneratedNever();
            builder.Property<string>("Numero").HasMaxLength(50).IsRequired();
            builder.ToTable("DDD");
        }
    }
}
