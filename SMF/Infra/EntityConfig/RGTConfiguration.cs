using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class RGConfiguration : IEntityTypeConfiguration<RG>
    {
        public void Configure(EntityTypeBuilder<RG> builder)
        {
            //builder.HasKey("RGId");
            //builder.Property(tp => tp.RGId).ValueGeneratedNever();
            builder.Property<string>("OrgaoEmissor").HasMaxLength(25).IsRequired();
            builder.ToTable("RG");
            
        }
    }
}
