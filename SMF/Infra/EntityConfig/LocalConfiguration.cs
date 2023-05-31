using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class LocalConfiguration : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.HasKey(u=> u.LocalId);
          /*  builder.HasOne(o=>o.Orgao).WithMany(u=>u.Locals).HasForeignKey(u=>u.OrgaoId);
            builder.Property(u => u.LocalId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(100);*/
          /*  builder.Property<string>("Local").HasMaxLength(20);
            builder.Property<string>("anoLocal").HasMaxLength(20);
            builder.Property<string>("Observacao").HasMaxLength(5000);
            builder.Property<string>("docencontrado").HasMaxLength(150);
            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            builder.ToTable("Local");
            
        }

      
    }
}
