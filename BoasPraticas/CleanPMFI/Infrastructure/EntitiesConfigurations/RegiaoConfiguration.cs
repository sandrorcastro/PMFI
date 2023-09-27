using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class RegiaoConfiguration : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            
                builder.HasKey(e => e.IdRegiao);
                builder.ToTable("Regiao");
                builder.Property(e => e.IdRegiao).ValueGeneratedNever();
            //builder.Property(e => e.Numero).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
                builder.Property(e => e.CentroGrauLat).HasMaxLength(25);//.IsRequired();
            builder.Property(e => e.PercentualUvc).HasColumnType("money");//.IsRequired();
            builder.Property(e => e.CentroGrauLon).HasMaxLength(25);//.IsRequired();
            builder.Property(e => e.Descricao).HasMaxLength(100);//.IsRequired();





        }
    }
}
