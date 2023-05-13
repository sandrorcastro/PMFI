using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class DocumentoPessoaConfiguration : IEntityTypeConfiguration<DocumentoPessoa>
    {
        public void Configure(EntityTypeBuilder<DocumentoPessoa> builder)
        {
            builder.HasKey("DocumentoPessoaId");
            builder.Property(tp => tp.DocumentoPessoaId).ValueGeneratedNever();
            builder.Property<string>("Numero").HasMaxLength(25).IsRequired();
            builder.ToTable("DocumentoPessoa");
            
        }
    }
}
