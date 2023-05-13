using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class CPFConfiguration : IEntityTypeConfiguration<CPF>
    {
        public void Configure(EntityTypeBuilder<CPF> builder)
        {
            
            
            builder.Property<string>("OrgaoEmissor").HasMaxLength(25).IsRequired();
            builder.ToTable("CPF");
            
        }
    }
}
