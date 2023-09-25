using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            
                builder.HasKey(e => e.IdDocumento);
                builder.ToTable("Documento");
                builder.Property(e => e.IdDocumento).ValueGeneratedNever();
                builder.HasOne(p => p.Pessoa).WithMany(d => d.Documentos);
                //builder.Property(e => e.Nome).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
            

        }
    }
}
