﻿using Microsoft.AspNetCore.Identity;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infra.EntityConfig
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            //builder.HasOne(p=>p.Servidor).WithMany().OnDelete(DeleteBehavior.NoAction);
            //builder.HasKey("Id");
            //builder.Property(tp => tp.ServidorId).ValueGeneratedNever();
        }
    }
}
