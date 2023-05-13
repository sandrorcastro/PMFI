

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infra.EntityConfig
{
    public class Economia_EntidadeConfiguration : IEntityTypeConfiguration<Economia_Entidade>
    {
        public void Configure(EntityTypeBuilder<Economia_Entidade> builder)
        {
            //  builder.HasKey(ep=> ep.Economia_EntidadeId);
            builder.HasKey(ep => new { ep.ImovelId, ep.EconomiaId, ep.PessoaId });
            //builder.HasMany(e => e.EconomiaId).WithMany();
            /// builder.HasOne(p => p.Pessoa).WithMany(ep => ep.Economias).HasForeignKey(ep => ep.PessoaId);
            builder.HasOne(i=>i.Imovel).WithMany(e => e.Economias).HasForeignKey(i=> i.ImovelId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Economia).WithMany(p=>p.Pessoas).HasForeignKey(e=>new {e.ImovelId,e.EconomiaId}).OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(e => e.Economia).WithOne("Imovel").OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Pessoa).WithMany(e=>e.Economias).HasForeignKey(p=> p.PessoaId).OnDelete(DeleteBehavior.NoAction);

            builder.Property(ep => ep.ImovelId).ValueGeneratedNever();
            builder.Property(ep => ep.EconomiaId).ValueGeneratedNever();
            builder.Property(ep => ep.PessoaId).ValueGeneratedNever();
            
            builder.Property<bool?>("Proprietario");
            //builder.Property<string>("inscricao");
            builder.Property<bool?>("Responsavel");
            builder.Property<bool?>("CoResponsavel");
            builder.Property<bool?>("Locatario");
            builder.Property<bool?>("Correspondente");
            
            //builder.Property<string>("edificacaoId").HasMaxLength(25); //.IsRequired();
            //builder.Property<string>("conId").HasMaxLength(25); //.IsRequired();


            //            builder.Property<string>("ConIdTEMP").HasMaxLength(50); //.IsRequired();
            //          builder.Property<string>("CEPTEMP").HasMaxLength(50); //.IsRequired();
            //builder.Property(p => p.DataCadastro).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder.ToTable("Economia_Entidade");
            
        }
    }
}


