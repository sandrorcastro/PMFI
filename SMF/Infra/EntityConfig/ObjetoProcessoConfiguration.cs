using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{ 
    public class ObjetoProcessoConfiguration : IEntityTypeConfiguration<ObjetoProcesso>
    {
        public void Configure(EntityTypeBuilder<ObjetoProcesso> builder)
        {
            //builder.HasKey("ObjetoProcessoId");
            builder.HasKey("ProcessoId");
           // builder.Property(p => p.ProcessoId).ValueGeneratedNever();
            builder.Property(p => p.ProcessoId).ValueGeneratedNever();
            builder.HasOne(o=>o.Economia).WithMany(op=>op.ObjetoProcessos).HasForeignKey(o=>new { o.ImovelId,o.EconomiaId });
            builder.HasOne(o => o.Imovel).WithMany(op => op.ObjetoProcessos).HasForeignKey(o => o.ImovelId);
            builder.HasOne(o => o.Pessoa).WithMany(op => op.ObjetoProcessos).HasForeignKey(o => o.PessoaId);
            builder.HasOne(o => o.Endereco).WithMany(op => op.ObjetoProcessos).HasForeignKey(o => o.EnderecoId);
            builder.Property<string>(op=>op.DescricaoObjetoProcesso).HasDefaultValue("Não Definido");
            builder.Property<int>(op => op.TipoObjetoProcesso).HasDefaultValue("1");
            //builder.Property<string>(op => op.DescricaoObjetoProcesso).HasDefaultValue("");
            builder.Property<string>("DescricaoObjetoProcesso").HasMaxLength(50).IsRequired();
            
            builder.ToTable("ObjetoProcesso");
            
        }
    }
}
