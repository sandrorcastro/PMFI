using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infra.EntityConfig
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey("EnderecoId");
            //builder.HasKey(e=> new { e.EnderecoId,e.CidadeId,e.BairroId});
            /*builder.HasOne(l => l.Logradouro).WithMany(e => e.Enderecos)
                                             .HasPrincipalKey(e => new { e.LogradouroId, e.CidadeId, e.BairroId })
                                             .HasForeignKey(l=> new { l.LogradouroId, l.CidadeId,l.BairroId});*/

            //builder.HasKey(e=> new { e.EnderecoId,e.CidadeId,e.BairroId});
            builder.Property(tp => tp.EnderecoId).ValueGeneratedNever();
            builder.Property(tp => tp.CidadeId).ValueGeneratedNever();
            builder.Property(tp => tp.BairroId).ValueGeneratedNever();
            builder.Property(tp => tp.LogradouroId).ValueGeneratedNever();
            builder.Property<string>("Complemento").HasMaxLength(500); //.IsRequired();
            builder.Property<string>("Referencia").HasMaxLength(500); //.IsRequired();
            builder.Property<string>("CEP").HasMaxLength(15); //.IsRequired();
            builder.Property<string>("logradouro_Temp").HasMaxLength(500); //.IsRequired();






            builder.ToTable("Endereco");
            
        }
    }
}
