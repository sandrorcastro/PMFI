using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityConfig
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey("ImageId");
            builder.Property(tp => tp.ImageId).ValueGeneratedNever();
            //builder.Property<string>("Descricao").HasMaxLength(50);
            builder.Property(p => p.CreateDate).HasDefaultValueSql("getdate()").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property<string>("ImageId").HasMaxLength(256);
            builder.Property<string>("NomeArquivo").HasMaxLength(150);
            builder.Property<string>("Caminho").HasMaxLength(200);
            builder.ToTable("Image");
            
        }
    }
}
