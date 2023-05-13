using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class PessoaFisicaConfiguration : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
             //builder.HasKey("PessoaId");
            //builder.Property<bigint>("PessoaId").HasColumnType("long");
            //builder.Property<string>("PessoaId").HasMaxLength(20);
           // builder.Property(tp => tp.PessoaId).ValueGeneratedNever();
            //HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            builder.Property<string>("PrimeiroNome").HasMaxLength(100);
            builder.Property<string>("NomeMeio").HasMaxLength(150);
            builder.Property<string>("Sobrenome").HasMaxLength(100);
            builder.Property<string>("Sexo").HasMaxLength(50);
            builder.Property<string>("EstadoCivil").HasMaxLength(50);
            builder.Property<string>("DefinicaoSexual").HasMaxLength(25);
            //  builder.Property<string>("Nacionalidade").HasMaxLength(50);

            //builder.Property(p => p.DataCadastro).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
             builder.ToTable("PessoaFisica");
            //builder.UseTpcMappingStrategy().ToTable("PessoaFisica", tableBuilder => tableBuilder.Property(pf => pf.PessoaId).HasColumnName("PessoaId"));
            //builder.UseTphMappingStrategy().ToTable("PessoaFisica"); //, tableBuilder => tableBuilder.Property(pf => pf.PessoaId).HasColumnName("PessoaId"));


        }
    }
}
