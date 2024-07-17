using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGContabilRepositorioDB
{
    public partial class GIIGContabilRepositorioDBContext : DbContext
    {
        public GIIGContabilRepositorioDBContext()
        {
        }

        public GIIGContabilRepositorioDBContext(DbContextOptions<GIIGContabilRepositorioDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCapConvAuxProgramasAnexo> TbCapConvAuxProgramasAnexos { get; set; } = null!;
        public virtual DbSet<TbDspEmpenhoAnexo> TbDspEmpenhoAnexos { get; set; } = null!;
        public virtual DbSet<TbDspLiquidacoesDocumentosDigitalizado> TbDspLiquidacoesDocumentosDigitalizados { get; set; } = null!;
        public virtual DbSet<TbDspPagamentosAnexo> TbDspPagamentosAnexos { get; set; } = null!;
        public virtual DbSet<TbDspRmsAnexo> TbDspRmsAnexos { get; set; } = null!;
        public virtual DbSet<TbOrcAudienciaAnexo> TbOrcAudienciaAnexos { get; set; } = null!;
        public virtual DbSet<TbSbsSubvencaoSocialAnexo> TbSbsSubvencaoSocialAnexos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=GIIGContabilRepositorioDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCapConvAuxProgramasAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tbCapConvAuxProgramasAnexos");

                entity.Property(e => e.IdAnexo).HasColumnName("idAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlPublicaPortalTransparencia)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalTransparencia")
                    .IsFixedLength();

                entity.Property(e => e.IdRecurso).HasColumnName("idRecurso");

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");
            });

            modelBuilder.Entity<TbDspEmpenhoAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tbDspEmpenhoAnexos");

                entity.Property(e => e.IdAnexo).HasColumnName("idAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlPublicaPortalFornecedor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalFornecedor")
                    .IsFixedLength();

                entity.Property(e => e.FlPublicaPortalTransparencia)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalTransparencia")
                    .IsFixedLength();

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");
            });

            modelBuilder.Entity<TbDspLiquidacoesDocumentosDigitalizado>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tbDspLiquidacoesDocumentosDigitalizados");

                entity.HasIndex(e => new { e.IdLiquidacaoDocto, e.FlPublicaPortalTransparencia }, "IX_tbDspLiquidacoesDocumentosDigitalizados_IdLiquidacaoDocto_flPublicaPortalTransparencia");

                entity.Property(e => e.IdAnexo).HasColumnName("idAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlPublicaPortalTransparencia)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalTransparencia")
                    .IsFixedLength();

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");
            });

            modelBuilder.Entity<TbDspPagamentosAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tbDspPagamentosAnexos");

                entity.Property(e => e.IdAnexo).HasColumnName("idAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlPublicaPortalFornecedor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalFornecedor")
                    .IsFixedLength();

                entity.Property(e => e.FlPublicaPortalTransparencia)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalTransparencia")
                    .IsFixedLength();

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");
            });

            modelBuilder.Entity<TbDspRmsAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tbDspRmsAnexos");

                entity.Property(e => e.IdAnexo).HasColumnName("idAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlPublicaPortalTransparencia)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalTransparencia")
                    .IsFixedLength();

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");

                entity.Property(e => e.NrSequencial).HasColumnName("nrSequencial");
            });

            modelBuilder.Entity<TbOrcAudienciaAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tbOrcAudienciaAnexos");

                entity.Property(e => e.IdAnexo).HasColumnName("idAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlPublicaPortalFornecedor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalFornecedor")
                    .IsFixedLength();

                entity.Property(e => e.FlPublicaPortalTransparencia)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalTransparencia")
                    .IsFixedLength();

                entity.Property(e => e.IdAudiencia).HasColumnName("idAudiencia");

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");
            });

            modelBuilder.Entity<TbSbsSubvencaoSocialAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tbSbsSubvencaoSocialAnexos");

                entity.Property(e => e.IdAnexo).HasColumnName("idAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlPublicaPortalFornecedor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalFornecedor")
                    .IsFixedLength();

                entity.Property(e => e.FlPublicaPortalTransparencia)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPublicaPortalTransparencia")
                    .IsFixedLength();

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
