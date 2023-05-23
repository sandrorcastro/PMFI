
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVC.EntityConfig
{
    public class Endereco_EntidadeConfiguration : IEntityTypeConfiguration<Endereco_Entidade>
    {
        public void Configure(EntityTypeBuilder<Endereco_Entidade> builder)
        {
            builder.HasKey(sc => new { sc.EntidadeId, sc.EnderecoId, sc.TipoEntidadeId,sc.Numero});
            //builder.HasOne(e => e.Economia).WithMany(x => x.Enderecos).HasPrincipalKey(x=> new { x.ImovelId,x.EconomiaId }).HasForeignKey(x=>x.EntidadeId);
            //builder.HasOne(e => e.Pessoa).WithMany(x => x.Enderecos).HasPrincipalKey(x => new { x.PessoaId}).HasForeignKey(x => x.ImovelId);
            //builder.HasOne(e => e.Economia).WithMany(e=>e.Enderecos).HasForeignKey(x=> x.EntidadeId );

            builder.Property(ep => ep.EntidadeId).ValueGeneratedNever();
            builder.Property(ep => ep.EnderecoId).ValueGeneratedNever();
            builder.Property(ep => ep.TipoEntidadeId).ValueGeneratedNever();
            builder.Property<string>("Numero").HasMaxLength(10); //.IsRequired();
            builder.ToTable("Endereco_Entidade");
            
        }
    }
}
