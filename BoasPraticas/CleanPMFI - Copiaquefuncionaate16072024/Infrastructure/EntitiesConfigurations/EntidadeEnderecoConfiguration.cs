using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class EntidadeEnderecoConfiguration : IEntityTypeConfiguration<EntidadeEndereco>
    {
        public void Configure(EntityTypeBuilder<EntidadeEndereco> builder)
        {
            
                builder.HasKey(e => e.IdEntidadeEndereco);
                builder.ToTable("EntidadeEndereco");
                builder.Property(e => e.IdEntidadeEndereco).ValueGeneratedNever();
            //builder.Property(e => e.Numero).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
                builder.Property(e => e.Numero).HasMaxLength(50);//.IsRequired();
                                                                 //builder.Property(e => e.Complemento).HasMaxLength(150);//.IsRequired();
                                                                 //builder.Property(e => e.Referencia).HasMaxLength(150);//.IsRequired();
                                                                 //builder.Property(e => e.CEP).HasMaxLength(10);//.IsRequired();
            //builder.HasOne(e => e.Enderecos).With(e => e.IdEndereco);


        }
    }
}
