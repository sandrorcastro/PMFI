using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class EtapaConfiguration : IEntityTypeConfiguration<Etapa>
    {
        public void Configure(EntityTypeBuilder<Etapa> builder)
        {
            //builder.HasKey(e => new { e.ProcessoId, e.TipoEtapaId,e.SituacaoEtapaId ,e.ImovelId,e.EconomiaId});
            builder.HasKey(e => new { e.ProcessoId, e.FluxoProcessoId});
            // builder.HasOne(e => e.Economia).WithMany();//.HasForeignKey(d => new {d.ImovelId,d.EconomiaId }); //.HasPrincipalKey(p => new { p.PessoaId });
            // builder.HasOne(e => e.Imovel).WithMany().HasForeignKey(d => new { d.ImovelId}); //.HasPrincipalKey(p => new { p.PessoaId });
            builder.HasOne(d => d.FluxoProcesso).WithMany().HasForeignKey(e => new { e.ProcessoId, e.FluxoProcessoId }).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(d => d.Processo).WithMany(e=>e.Etapas).HasForeignKey(p=>p.ProcessoId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()");
            builder.Property<string>("Ano").HasMaxLength(4); //.IsRequired();
            builder.Property<string>("protocolo").HasMaxLength(20);
            builder.Property<string>("anoprotocolo").HasMaxLength(20);
            builder.Property<string>("ObservacaoEtapa").HasMaxLength(5000); //.IsRequired();
            builder.ToTable("Etapa");
            
            
            
        }
    }
}





