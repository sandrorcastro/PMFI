
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Models;

namespace MVC.EntityConfig
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
         





            builder.ToTable("Endereco");
            
        }
    }
}
