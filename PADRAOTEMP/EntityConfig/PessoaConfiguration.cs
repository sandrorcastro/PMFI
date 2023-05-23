
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Models;

namespace MVC.EntityConfig
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
           builder.HasKey("PessoaId");
           builder.Property(tp => tp.PessoaId).ValueGeneratedNever();
           builder.ToTable("Pessoa");

        }
    }
}
