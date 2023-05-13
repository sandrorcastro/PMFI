using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class LogradouroConfiguration : IEntityTypeConfiguration<Logradouro>
    {
        public void Configure(EntityTypeBuilder<Logradouro> builder)
        {
            builder.HasKey("LogradouroId");
           //builder.HasKey(l=> new { l.LogradouroId, l.CidadeId, l.BairroId });
           /* builder.HasMany(e => e.Enderecos)
                   .WithOne(e => e.Logradouro)
                   .HasPrincipalKey(l => new { l.LogradouroId,l.CidadeId,l.BairroId})
                   .HasForeignKey( e => new {e.EnderecoId,e.CidadeId,e.BairroId })
                   .IsRequired();*/
            builder.Property(tp => tp.LogradouroId).ValueGeneratedNever();
            builder.Property(tp => tp.CidadeId).ValueGeneratedNever();
            builder.Property(tp => tp.BairroId).ValueGeneratedNever();
            builder.Property(tp => tp.TipoLogradouroId).ValueGeneratedNever();
            builder.Property(tp => tp.CEP).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(250); //.IsRequired();
            builder.ToTable("Logradouro");
        }
    }
}
