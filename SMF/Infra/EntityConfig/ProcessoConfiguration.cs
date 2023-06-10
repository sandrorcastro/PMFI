using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig    
{
    public class ProcessoConfiguration : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
         
            builder.HasKey(p => p.ProcessoId);
            builder.Property(tp => tp.ProcessoId).ValueGeneratedNever();
            builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()");
            builder.HasOne(p => p.Orgao).WithMany().HasForeignKey(u => u.OrgaoId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.OrgaoDestinatario).WithMany().HasForeignKey(u => u.OrgaoDestinatarioId).OnDelete(DeleteBehavior.NoAction); 
            builder.HasOne(p => p.OrgaoRemetente).WithMany().HasForeignKey(u => u.OrgaoRemetenteId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Divisao).WithMany(p=>p.Processos).HasForeignKey(u => u.DivisaoId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.DivisaoRemetente).WithMany().HasForeignKey(u => u.DivisaoRemetenteId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.DivisaoDestinatario).WithMany().HasForeignKey(u => u.DivisaoDestinatarioId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.TipoProcesso).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Unidade).WithMany(p=>p.Processos).HasForeignKey(u=>u.UnidadeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.UnidadeRemetente).WithMany().HasForeignKey(u => u.UnidadeRemetenteId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.UnidadeDestinatario).WithMany().HasForeignKey(u=>u.UnidadeDestinatarioId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.ObjetoProcesso).WithOne(p=>p.Processo).HasForeignKey<ObjetoProcesso>(op=>op.ProcessoId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.ServidorExecutor).WithMany(p => p.ExecutaProcessos).HasForeignKey(s => s.ServidorExecutorId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Servidor).WithMany(p => p.Processos).HasForeignKey(s => s.ServidorId).OnDelete(DeleteBehavior.NoAction);
            builder.Property<string>("ObservacaoProcesso").HasMaxLength(1000);

             /*builder.Property<string>("Ano").HasMaxLength(4);
             builder.Property<string>("protocolo").HasMaxLength(20);
             builder.Property<string>("anoprotocolo").HasMaxLength(20);
             builder.Property<string>("Observacao").HasMaxLength(5000);
             builder.Property<string>("docencontrado").HasMaxLength(150);
             builder.Property(p => p.DataInicio).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            builder.ToTable("Processo");
            
        }

      
    }
}
