using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
           builder.HasKey("PessoaId");
            
            //builder.HasKey(p => new { p.ConId, p.PessoaId});
            //builder.Property<bigint>("PessoaId").HasColumnType("long");
            //builder.Property<string>("PessoaId").HasMaxLength(20);
            builder.Property(tp => tp.PessoaId).ValueGeneratedNever();
                //HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            builder.Property<string>("Nome").HasMaxLength(250).IsRequired();
            //builder.Property<string>("email").HasMaxLength(100);
            //builder.Property<string>("telefonecomercial").HasMaxLength(20);
            //builder.Property<string>("telefoneresidencial").HasMaxLength(20);
            //builder.Property<string>("celular").HasMaxLength(20);
            //builder.Property<string>("telefones").HasMaxLength(250);
            builder.Property<bool?>("Ativo").HasDefaultValue(true);
            builder.Property(p => p.DataCadastro).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            //builder.UseTpcMappingStrategy().ToTable("Pessoa");
            builder.ToTable("Pessoa");

        }
    }
}
