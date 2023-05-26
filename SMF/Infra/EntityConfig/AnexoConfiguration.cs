using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class AnexoConfiguration : IEntityTypeConfiguration<Anexo>
    {
        public void Configure(EntityTypeBuilder<Anexo> builder)
        {
            builder.HasKey("ProcessoId,FluxoProcessoId,TipoProcessoId,AnexoId");
            builder.Property(p => p.DataCadastro).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property<string>("AnexoId").HasMaxLength(256);
            builder.Property<string>("NomeArquivo").HasMaxLength(150);
            builder.Property<string>("Caminho").HasMaxLength(200);
            builder.Property<string>("TipoAnexo").HasMaxLength(50);

            builder.ToTable("Anexo");
            
        }
    }
}
