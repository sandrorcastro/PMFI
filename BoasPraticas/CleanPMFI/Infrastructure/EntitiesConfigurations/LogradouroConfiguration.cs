using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class LogradouroConfiguration : IEntityTypeConfiguration<Logradouro>
    {
        public void Configure(EntityTypeBuilder<Logradouro> builder)
        {
            
                builder.HasKey(e => e.IdLogradouro);
                builder.ToTable("Logradouro");
            //   builder.HasOne(tp => tp.TipoLogradouro).WithMany();
            builder.HasOne(d => d.TipoLogradouro).WithMany(p => p.Logradouros).HasForeignKey(d => d.IdTipoLogradouro);//.HasConstraintName("fk_logradouro_tipologradouro");
                builder.Property(e => e.IdLogradouro).ValueGeneratedNever();//.HasColumnName("id_pais");
                builder.Property(e => e.NomeLogradouro).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
            

        }
    }
}
