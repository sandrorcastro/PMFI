using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class OrgaoConfiguration : IEntityTypeConfiguration<Orgao>
    {
        public void Configure(EntityTypeBuilder<Orgao> builder)
        {
            builder.HasKey(o=> o.OrgaoId);
            builder.Property(o => o.OrgaoId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(100);
            /*builder.Property<string>("Orgao").HasMaxLength(20);
            builder.Property<string>("anoOrgao").HasMaxLength(20);
            builder.Property<string>("Observacao").HasMaxLength(5000);
            builder.Property<string>("docencontrado").HasMaxLength(150);
            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            builder.ToTable("Orgao");
            
        }

      
    }
}
