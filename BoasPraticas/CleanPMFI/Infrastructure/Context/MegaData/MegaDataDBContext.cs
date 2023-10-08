using System;
using System.Collections.Generic;
using Domain.Entities.MegaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Context //.MegaData
{
    public partial class MegaDataDBContext : DbContext
    {
        public MegaDataDBContext()
        {
        }

        public MegaDataDBContext(DbContextOptions<MegaDataDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MegaData_NFSE> MegaData_NFSEs { get; set; } = null!;
       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=NFSEDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
                optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=NFSEDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<MegaData_NFSE>(entity =>
            {
                entity.HasKey(e => e.DataGeracao);

                entity.ToTable("MegaData_NFSE");
               // entity.HasIndex(e => new { e.DataGeracao }, "IX_MegaData_NFSE_DataGeracao");
                entity.Property(e => e.DataGeracao).ValueGeneratedNever();
                entity.Property(e => e.DataInicioPeriodo).ValueGeneratedNever();
                entity.Property(e => e.DataFinalPeriodo).ValueGeneratedNever();
                entity.Property(e => e.DataEnvio).ValueGeneratedNever();
                

            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
