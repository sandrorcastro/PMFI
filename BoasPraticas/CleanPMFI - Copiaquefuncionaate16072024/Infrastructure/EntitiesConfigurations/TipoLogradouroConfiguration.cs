using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class TipoLogradouroConfiguration : IEntityTypeConfiguration<TipoLogradouro>
    {
        public void Configure(EntityTypeBuilder<TipoLogradouro> builder)
        {
            
                builder.HasKey(e => e.IdTipoLogadouro);
                builder.ToTable("TipoLogradouro");
                builder.Property(e => e.IdTipoLogadouro).ValueGeneratedNever();//.HasColumnName("id_pais");
                builder.Property(e => e.Dstipologradouro).HasMaxLength(50).IsUnicode(false);//.HasColumnName("nome");
            

        }
    }
}
