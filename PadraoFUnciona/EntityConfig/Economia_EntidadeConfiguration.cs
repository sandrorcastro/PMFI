using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Models;
using System.Reflection.Emit;

namespace MVC.EntityConfig
{
    public class Economia_EntidadeConfiguration : IEntityTypeConfiguration<Economia_Entidade>
    {
        public void Configure(EntityTypeBuilder<Economia_Entidade> builder)
        {
            
            builder.HasKey(ep => new { ep.ImovelId, ep.EconomiaId, ep.PessoaId });
            builder.HasOne(i=>i.Imovel).WithMany(e => e.Economias).HasForeignKey(i=> i.ImovelId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Pessoa).WithMany(e=>e.Economias).HasForeignKey(p=> p.PessoaId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(ep => ep.ImovelId).ValueGeneratedNever();
            builder.Property(ep => ep.EconomiaId).ValueGeneratedNever();
            builder.Property(ep => ep.PessoaId).ValueGeneratedNever();
            builder.ToTable("Economia_Entidade");
            
        }
    }
}


