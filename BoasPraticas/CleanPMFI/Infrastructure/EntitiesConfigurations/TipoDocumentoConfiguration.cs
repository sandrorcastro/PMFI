using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            
                builder.HasKey(e => e.IdTipoDocumento);
                builder.ToTable("TipoDocumento");
                builder.Property(e => e.IdTipoDocumento).ValueGeneratedNever();
            //  builder.HasOne(p => p.Pessoa).WithMany(d => d.TipoDocumentos);
            //builder.Property(e => e.SiglaDoc).HasMaxLength(10).IsUnicode(false).HasColumnName("nome");
            builder.Property(e => e.SiglaDoc).HasMaxLength(10);
            builder.Property(e => e.Descricao).HasMaxLength(100);


        }
    }
}
