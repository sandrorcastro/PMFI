using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class Contato_PessoaConfiguration : IEntityTypeConfiguration<Contato_Pessoa>
    {
        public void Configure(EntityTypeBuilder<Contato_Pessoa> builder)
        {
            builder.HasKey(cp => new { cp.ContatoId, cp.PessoaId });
            builder.Property(ep => ep.ContatoId).ValueGeneratedNever();
            builder.Property(ep => ep.PessoaId).ValueGeneratedNever();
            builder.Property(p => p.DataCadastro).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property<bool?>("Ativo").HasDefaultValue(true);
            // builder.Property(p => p.DataUltimaAlteracao).HasDefaultValueSql(null).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.ToTable("Contato_Pessoa");
            
        }
    }
}
