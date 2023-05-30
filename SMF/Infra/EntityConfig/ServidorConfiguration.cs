using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class ServidorConfiguration : IEntityTypeConfiguration<Servidor>
    {
        public void Configure(EntityTypeBuilder<Servidor> builder)
        {
            builder.HasKey("ServidorId");
            builder.HasOne(u=>u.Divisao).WithMany(s=>s.Servidores).HasForeignKey(u=>u.DivisaoId);
            builder.Property(tp => tp.ServidorId).ValueGeneratedNever();
            builder.Property<string>("Nome").HasMaxLength(150);
            builder.Property<string>("Matricula").HasMaxLength(15);
            builder.Property<string>("Cargo").HasMaxLength(100);
            builder.Property<string>("Funcao").HasMaxLength(100);
            builder.Property<bool?>("Ativo").HasDefaultValue(true);
            builder.ToTable("Servidor");
            
            
        }
    }
}
