using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            
                builder.HasKey(e => e.IdEndereco);
                builder.ToTable("Endereco");
                builder.Property(e => e.IdEndereco).ValueGeneratedNever();
            //builder.Property(e => e.Numero).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
                builder.Property(e => e.Numero).HasMaxLength(50);//.IsRequired();
                builder.Property(e => e.Complemento).HasMaxLength(150);//.IsRequired();
                builder.Property(e => e.Referencia).HasMaxLength(150);//.IsRequired();
                builder.Property(e => e.CEP).HasMaxLength(15);//.IsRequired();


        }
    }
}
