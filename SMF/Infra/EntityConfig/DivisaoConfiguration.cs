using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class DivisaoConfiguration : IEntityTypeConfiguration<Divisao>
    {
        public void Configure(EntityTypeBuilder<Divisao> builder)
        {
            builder.HasKey(u=> u.DivisaoId);
            builder.HasOne(o=>o.Unidade).WithMany(u=>u.Divisoes).HasForeignKey(u=>u.UnidadeId);
            builder.HasOne(r=>r.ServidorResponsavel).WithMany().HasForeignKey(s=>s.ServidorResponsavelId).OnDelete(DeleteBehavior.NoAction);
            //builder.HasMany(r => r.ServidorResponsavel).WithOne().HasForeignKey(s => s.ServidorResponsavelId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(u => u.DivisaoId).ValueGeneratedNever();
            //builder.Property<string>("Descricao").HasMaxLength(100);
          
            builder.Property<string>("Descricao").HasMaxLength(150);
            builder.Property<string>("Atribuicao").HasMaxLength(500);
           /* builder.Property<string>("Observacao").HasMaxLength(5000);
            builder.Property<string>("docencontrado").HasMaxLength(150);
            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            builder.ToTable("Divisao");
            
        }

      
    }
}
