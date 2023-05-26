using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class ProcessoConfiguration : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            //builder.HasKey(p => p.ProtocoloId );
            //builder.HasKey(p => new { p.OrgaoId, p.SequenciaNumerica, p.Ano, p.DigitoVerificador });
            builder.HasKey(p=>p.ProcessoId);


            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()");
            builder.HasOne(p => p.Orgao).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.TipoProcesso).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p=>p.OrgaoRemetente).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.UnidadeRemetente).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.OrgaoDestinatario).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.UnidadeDestinatario).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Imovel).WithMany(p=>p.Processos).HasForeignKey(i=>i.ImovelId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Economia).WithMany(p => p.Processos).HasForeignKey(i => new { i.ImovelId ,i.EconomiaId }).OnDelete(DeleteBehavior.NoAction);
            //  builder.HasOne(p => p.Protocolo).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.Property<string>("ObservacaoProcesso").HasMaxLength(1000);

            /* builder.Property(tp => tp.ProcessoId).ValueGeneratedNever();
             builder.Property<string>("Ano").HasMaxLength(4);
             builder.Property<string>("protocolo").HasMaxLength(20);
             builder.Property<string>("anoprotocolo").HasMaxLength(20);
             builder.Property<string>("Observacao").HasMaxLength(5000);
             builder.Property<string>("docencontrado").HasMaxLength(150);
             builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            builder.ToTable("Processo");
            
        }

      
    }
}
