using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class PessoaJuridicaConfiguration : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            // builder.HasKey("PessoaId");
            //builder.Property<bigint>("PessoaId").HasColumnType("long");
            //builder.Property<string>("PessoaId").HasMaxLength(20);
            //builder.Property(tp => tp.PessoaId).ValueGeneratedNever();
            //HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            builder.Property<string>("RazaoSocial").HasMaxLength(500);
            builder.Property<string>("NomeFantasia").HasMaxLength(500);
            builder.Property<string>("InscricaoEstadual").HasMaxLength(50);

            //builder.Property(p => p.DataCadastro).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            //builder.UseTpcMappingStrategy().ToTable("PessoaJuridica");
            //builder.UseTphMappingStrategy().ToTable("PessoaJuridica");
            builder.ToTable("PessoaJuridica");

        }
    }
}
