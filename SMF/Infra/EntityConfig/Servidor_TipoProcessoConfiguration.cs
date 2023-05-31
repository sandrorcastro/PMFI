

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infra.EntityConfig
{
    public class Servidor_TipoProcessoConfiguration : IEntityTypeConfiguration<Servidor_TipoProcesso>
    {
        public void Configure(EntityTypeBuilder<Servidor_TipoProcesso> builder)
        {
            //  builder.HasKey(ep=> ep.Servidor_TipoProcessoId);
            builder.HasKey(ep => new { ep.ServidorId, ep.TipoProcessoId });
            builder.HasOne(i => i.Servidor).WithMany(e => e.PodeExecutar).HasForeignKey(i=> i.ServidorId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(i => i.TipoProcesso).WithMany(e => e.ExecutadoPor).HasForeignKey(i => i.TipoProcessoId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(ep => ep.ServidorId).ValueGeneratedNever();
            builder.Property(ep => ep.TipoProcessoId).ValueGeneratedNever();
            builder.ToTable("Servidor_TipoProcesso");
            
        }
    }
}


