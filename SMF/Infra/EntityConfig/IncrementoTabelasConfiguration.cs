using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class IncrementoTabelasConfiguration : IEntityTypeConfiguration<IncrementoTabelas>
    {
        public void Configure(EntityTypeBuilder<IncrementoTabelas> builder)
        {

            builder.HasKey("IncrementoTabelasId");
            builder.Property(i => i.IncrementoTabelasId).ValueGeneratedNever();
            builder.Property<string>("Tabela").HasMaxLength(50); //.IsRequired();
            builder.Property<string>("Ano").HasMaxLength(4); //.IsRequired();

            builder.ToTable("IncrementoTabelas");
            
        }
    }
}
