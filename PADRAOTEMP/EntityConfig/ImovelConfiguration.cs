
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC.Models;

namespace MVC.EntityConfig
{
    public class ImovelConfiguration : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.HasKey("ImovelId");
            
            builder.Property(tp => tp.ImovelId).ValueGeneratedNever();
          
       
            builder.ToTable("Imovel");
            
        }
    }
}
