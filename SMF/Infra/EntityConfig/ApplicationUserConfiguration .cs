using Microsoft.AspNetCore.Identity;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//namespace Infra.
namespace Infra.Context
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey("Id");
            builder.Property(tp => tp.Id).ValueGeneratedNever();
            builder.Property(tp => tp.ServidorId).ValueGeneratedNever();
            builder.HasOne(p=>p.Servidor).WithMany().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
