using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            
                builder.HasKey(e => e.IdPessoa);
                builder.ToTable("Pessoa");
                builder.Property(e => e.IdPessoa).ValueGeneratedNever();
            //builder.Property(e => e.Numero).HasMaxLength(50).IsUnicode(false).HasColumnName("nome");
             




        }
    }
}
