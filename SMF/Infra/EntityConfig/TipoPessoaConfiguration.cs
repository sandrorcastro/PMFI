using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class TipoPessoaConfiguration : IEntityTypeConfiguration<TipoPessoa>
    {
        public void Configure(EntityTypeBuilder<TipoPessoa> builder)
        {
            builder.HasKey("TipoPessoaId");
            builder.Property(tp => tp.TipoPessoaId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(50).IsRequired();
            builder.ToTable("TipoPessoa");
            builder.HasData(new TipoPessoa
            {
                TipoPessoaId = 1,
                Descricao = "FÍSICA"
            }, new TipoPessoa
            {
                TipoPessoaId = 2,
                Descricao = "JURÍDICA"
            }
            );
        }
    }
}
