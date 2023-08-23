using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMFI.Infra.Context;

namespace PMFI.Infra.EntitiesConfigurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(p => p.UserName).HasColumnType("varchar").HasMaxLength(256);
        builder.Property(p => p.NormalizedUserName).HasColumnType("varchar").HasMaxLength(256);
        builder.Property(p => p.Email).HasColumnType("varchar").HasMaxLength(256).IsRequired();
        builder.Property(p => p.NormalizedEmail).HasColumnType("varchar").HasMaxLength(256);
        builder.Property(p => p.PasswordHash).HasColumnType("varchar").HasMaxLength(500);
        builder.Property(p => p.SecurityStamp).HasColumnType("varchar").HasMaxLength(500);
        builder.Property(p => p.ConcurrencyStamp).HasColumnType("varchar").HasMaxLength(500);
        builder.Property(p => p.PhoneNumber).HasColumnType("varchar").HasMaxLength(30);

        builder.HasIndex(p => p.Email).IsUnique();
        builder.HasIndex(p => p.UserName).IsUnique();
    }
}