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
            //  builder.HasKey(ep=> ep.Economia_EntidadeId);
            builder.HasKey(ep => new { ep.ImovelId, ep.EconomiaId, ep.PessoaId });
            //builder.HasMany(e => e.EconomiaId).WithMany();
            /// builder.HasOne(p => p.Pessoa).WithMany(ep => ep.Economias).HasForeignKey(ep => ep.PessoaId);
            builder.HasOne(i=>i.Imovel).WithMany(e => e.Economia_Entidades).HasForeignKey(i=> i.ImovelId).OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(e => e.Economia).WithMany(p=>p.Pessoas).HasForeignKey(e=>new {e.ImovelId,e.EconomiaId}).OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(e => e.Economia).WithOne("Imovel").OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Pessoa).WithMany(e=>e.Economia_Entidades).HasForeignKey(p=> p.PessoaId).OnDelete(DeleteBehavior.NoAction);

            builder.Property(ep => ep.ImovelId).ValueGeneratedNever();
            builder.Property(ep => ep.EconomiaId).ValueGeneratedNever();
            builder.Property(ep => ep.PessoaId).ValueGeneratedNever();
            
           

            builder.ToTable("Economia_Entidade");
            
        }
    }
}


