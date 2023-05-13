using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class OperadoraTelefoneConfiguration : IEntityTypeConfiguration<OperadoraTelefone>
    {
        public void Configure(EntityTypeBuilder<OperadoraTelefone> builder)
        {
            builder.HasKey(u=> u.OperadoraTelefoneId);
            builder.Property(u => u.OperadoraTelefoneId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(50);
            builder.Property<string>("CodigoOperadora").HasMaxLength(10);
            builder.ToTable("OperadoraTelefone");
            
        }

      
    }
}
