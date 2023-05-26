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
            builder.HasKey(e => new { e.ProcessoId, e.FluxoProcessoId,e.TipoProcessoId});
            builder.HasOne(d => d.FluxoProcesso).WithMany(e=>e.Etapas).HasForeignKey(e => new { e.FluxoProcessoId ,e.TipoProcessoId}).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(d => d.Processo).WithMany(e=>e.Etapas).HasForeignKey(p=>p.ProcessoId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(d => d.Anexos).WithOne(e=>e.Etapa).HasForeignKey(p=> new { p.ProcessoId,p.FluxoProcessoId,p.TipoProcessoId }).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()");
            builder.Property<string>("Ano").HasMaxLength(4); //.IsRequired();
            builder.Property<string>("protocolo").HasMaxLength(20);
            builder.Property<string>("anoprotocolo").HasMaxLength(20);
            builder.Property<string>("ObservacaoEtapa").HasMaxLength(5000); //.IsRequired();
            builder.ToTable("Etapa");
            
            
            
        }
    }
}





