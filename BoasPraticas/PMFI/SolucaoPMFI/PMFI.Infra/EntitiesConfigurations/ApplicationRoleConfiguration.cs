using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMFI.Infra.Context;

namespace PMFI.Infra.EntitiesConfigurations;

public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> builder)
    {
        builder.Property(p => p.Name).HasColumnType("varchar").HasMaxLength(256);
        builder.Property(p => p.NormalizedName).HasColumnType("varchar").HasMaxLength(256);
        builder.Property(p => p.ConcurrencyStamp).HasColumnType("varchar").HasMaxLength(256);
    }
}