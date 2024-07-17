using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class BairroConfiguration : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
                builder.HasKey(e => e.IdBairro);
                builder.ToTable("Bairro");
                builder.Property(e => e.IdBairro).ValueGeneratedNever();
                builder.Property(e => e.Nome).HasMaxLength(150);
                builder.HasOne(r => r.Regiao).WithMany().HasForeignKey(r=>r.IdRegiao);
        }
    }
}
