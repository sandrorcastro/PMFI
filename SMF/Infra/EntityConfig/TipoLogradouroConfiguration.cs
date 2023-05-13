
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EntityConfig
{
    public class TipoLogradouroConfiguration : IEntityTypeConfiguration<TipoLogradouro>
    {
        public void Configure(EntityTypeBuilder<TipoLogradouro> builder)
        {
            builder.HasKey("TipoLogradouroId");
            builder.Property(tp => tp.TipoLogradouroId).ValueGeneratedNever();
            builder.Property<string>("Descricao").HasMaxLength(250); //.IsRequired();
            builder.ToTable("TipoLogradouro");
            
        }
       
    }
}
