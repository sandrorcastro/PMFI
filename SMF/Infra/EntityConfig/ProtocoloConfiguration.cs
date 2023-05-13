using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class ProtocoloConfiguration : IEntityTypeConfiguration<Protocolo>
    {
        public void Configure(EntityTypeBuilder<Protocolo> builder)
        {
            builder.HasKey(p  => new {p.OrgaoId,p.SequenciaNumerica,p.Ano,p.DigitoVerificador});
            builder.Property(p => p.OrgaoId).ValueGeneratedNever();
            builder.Property(p => p.SequenciaNumerica).ValueGeneratedNever();
            builder.Property(p => p.Ano).ValueGeneratedNever();
            builder.Property(p => p.DigitoVerificador).ValueGeneratedNever();
            /* builder.Property<string>("Ano").HasMaxLength(4);
             builder.Property<string>("protocolo").HasMaxLength(20);
             builder.Property<string>("anoprotocolo").HasMaxLength(20);
             builder.Property<string>("Observacao").HasMaxLength(5000);
             builder.Property<string>("docencontrado").HasMaxLength(150);*/
            // builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            //builder.Property(p=>p.Ano).HasColumnType("date").HasComputedColumnSql("DATEFROMPARTS(YEAR(Ano), 1, 1)");
            builder.ToTable("Protocolo");
            
        }

      
    }
}
