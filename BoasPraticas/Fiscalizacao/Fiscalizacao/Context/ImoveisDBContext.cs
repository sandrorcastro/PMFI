using System;
using System.Collections.Generic;
using Fiscalizacao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fiscalizacao.Context 
{
    public partial class ImoveisDBContext : DbContext
    {
        public ImoveisDBContext()
        {
        }

        public ImoveisDBContext(DbContextOptions<ImoveisDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Imovel> Imoveis { get; set; } = null!;
       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlite(Constants.DatabasePath);
                optionsBuilder.UseSqlite("Data Source = NaRua.db3");


                
               // optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=NFSEDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<Imovel>(entity =>
            {

                entity.HasNoKey();
                
                
                entity.ToTable("Imovel");
                // entity.HasIndex(e => new { e.DataGeracao }, "IX_MegaData_NFSE_DataGeracao");
                /*entity.Property(e => e.IDMegaData_NFSE).ValueGeneratedNever();
                entity.Property(e => e.DataGeracao).ValueGeneratedNever();
                entity.Property(e => e.DataInicioPeriodo).ValueGeneratedNever();
                entity.Property(e => e.DataFinalPeriodo).ValueGeneratedNever();
                entity.Property(e => e.DataEnvio).ValueGeneratedNever();
                entity.Property(e => e.NomeArquivo).HasMaxLength(150);//.IsRequired();
                entity.Property(e => e.CaminhoArquivo).HasMaxLength(250);//.IsRequired();
                entity.Property(e => e.TipoArquivo).HasMaxLength(25);//.IsRequired();*/

            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
