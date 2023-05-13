using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class UnidadeConfiguration : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.HasKey(u=> u.UnidadeId);
            builder.Property(u => u.UnidadeId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(100);
          /*  builder.Property<string>("Unidade").HasMaxLength(20);
            builder.Property<string>("anoUnidade").HasMaxLength(20);
            builder.Property<string>("Observacao").HasMaxLength(5000);
            builder.Property<string>("docencontrado").HasMaxLength(150);
            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            builder.ToTable("Unidade");
            
        }

      
    }
}
