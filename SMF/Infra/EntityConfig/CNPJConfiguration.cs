using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class CNPJConfiguration : IEntityTypeConfiguration<CNPJ>
    {
        public void Configure(EntityTypeBuilder<CNPJ> builder)
        {
            
            
            builder.Property<string>("OrgaoEmissor").HasMaxLength(25).IsRequired();
            builder.ToTable("CNPJ");
            
        }
    }
}
