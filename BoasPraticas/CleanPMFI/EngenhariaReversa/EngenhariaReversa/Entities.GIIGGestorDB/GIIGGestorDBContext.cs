using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class GIIGGestorDBContext : DbContext
    {
        public GIIGGestorDBContext()
        {
        }

        public GIIGGestorDBContext(DbContextOptions<GIIGGestorDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbGerRssAtiva> TbGerRssAtivas { get; set; } = null!;
        public virtual DbSet<TbGerRssPadrao> TbGerRssPadraos { get; set; } = null!;
        public virtual DbSet<TbGerRssUsuario> TbGerRssUsuarios { get; set; } = null!;
        public virtual DbSet<TbGraFonteDado> TbGraFonteDados { get; set; } = null!;
        public virtual DbSet<TbGraGrafico> TbGraGraficos { get; set; } = null!;
        public virtual DbSet<TbGraVisaoFonteDado> TbGraVisaoFonteDados { get; set; } = null!;
        public virtual DbSet<TbTmpDespesasPorNatureza> TbTmpDespesasPorNaturezas { get; set; } = null!;
        public virtual DbSet<TbTmpEmpenhosPorOrgao> TbTmpEmpenhosPorOrgaos { get; set; } = null!;
        public virtual DbSet<TbTmpFuncaoSubFuncao> TbTmpFuncaoSubFuncaos { get; set; } = null!;
        public virtual DbSet<TbTmpReceitaArrecadadum> TbTmpReceitaArrecadada { get; set; } = null!;
        public virtual DbSet<TbTmpRmsAprovadasOrgao> TbTmpRmsAprovadasOrgaos { get; set; } = null!;
        public virtual DbSet<Tmp50MaioresCredores2012> Tmp50MaioresCredores2012s { get; set; } = null!;
        public virtual DbSet<Tmp50MaioresCredores2015> Tmp50MaioresCredores2015s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGGestorDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<TbGerRssAtiva>(entity =>
            {
                entity.HasKey(e => new { e.IdRssPadrao, e.IdRssUsuario, e.DsLogin })
                    .HasName("PK_tbGerRssAtiva_1");

                entity.ToTable("tbGerRssAtiva");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsNomeRss)
                    .HasMaxLength(100)
                    .HasColumnName("dsNomeRss");
            });

            modelBuilder.Entity<TbGerRssPadrao>(entity =>
            {
                entity.HasKey(e => e.IdRssPadrao);

                entity.ToTable("tbGerRssPadrao");

                entity.Property(e => e.DsLinkRss)
                    .HasMaxLength(150)
                    .HasColumnName("dsLinkRss");

                entity.Property(e => e.DsNomeRss)
                    .HasMaxLength(100)
                    .HasColumnName("dsNomeRss");
            });

            modelBuilder.Entity<TbGerRssUsuario>(entity =>
            {
                entity.HasKey(e => e.IdRssUsuario);

                entity.ToTable("tbGerRssUsuario");

                entity.Property(e => e.DsLinkRss)
                    .HasMaxLength(150)
                    .HasColumnName("dsLinkRss");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsNomeRss)
                    .HasMaxLength(100)
                    .HasColumnName("dsNomeRss");
            });

            modelBuilder.Entity<TbGraFonteDado>(entity =>
            {
                entity.HasKey(e => e.IdFonteDados);

                entity.ToTable("tbGraFonteDados");

                entity.Property(e => e.DsFonteDados)
                    .IsUnicode(false)
                    .HasColumnName("dsFonteDados");

                entity.Property(e => e.NmFonteDados)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmFonteDados");

                entity.Property(e => e.NmProvider)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmProvider");

                entity.Property(e => e.NmTemporyTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTemporyTable");
            });

            modelBuilder.Entity<TbGraGrafico>(entity =>
            {
                entity.HasKey(e => e.IdGrafico);

                entity.ToTable("tbGraGraficos");

                entity.Property(e => e.DsOperador)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsOperador");

                entity.Property(e => e.FlChart3D).HasColumnName("flChart3D");

                entity.Property(e => e.FlMostrarLegenda).HasColumnName("flMostrarLegenda");

                entity.Property(e => e.FlRecursiveChart).HasColumnName("flRecursiveChart");

                entity.Property(e => e.NmFieldId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmFieldId");

                entity.Property(e => e.NmFieldIdFilter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmFieldIdFilter");

                entity.Property(e => e.NmGrafico)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmGrafico");

                entity.Property(e => e.XvalueMember)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XValueMember");

                entity.Property(e => e.YvalueMembers)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("YValueMembers");

                entity.HasOne(d => d.IdVisaoNavigation)
                    .WithMany(p => p.TbGraGraficos)
                    .HasForeignKey(d => d.IdVisao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbGraGraficos_tbGraVisaoFonteDados");
            });

            modelBuilder.Entity<TbGraVisaoFonteDado>(entity =>
            {
                entity.HasKey(e => e.IdVisao);

                entity.ToTable("tbGraVisaoFonteDados");

                entity.Property(e => e.DsQuery)
                    .IsUnicode(false)
                    .HasColumnName("dsQuery");

                entity.Property(e => e.NmVisao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmVisao");

                entity.HasOne(d => d.IdFonteDadosNavigation)
                    .WithMany(p => p.TbGraVisaoFonteDados)
                    .HasForeignKey(d => d.IdFonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbGraVisaoFonteDados_tbGraFonteDados");
            });

            modelBuilder.Entity<TbTmpDespesasPorNatureza>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesasPorNatureza");

                entity.Property(e => e.Descrição)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descrição");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Idnatdespesa).HasColumnName("idnatdespesa");

                entity.Property(e => e.Idnatdespesanivelsuper).HasColumnName("idnatdespesanivelsuper");

                entity.Property(e => e.Naturezadespesa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("naturezadespesa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Vltotalempenhado)
                    .HasColumnType("money")
                    .HasColumnName("vltotalempenhado");

                entity.Property(e => e.Vltotalliquidado)
                    .HasColumnType("money")
                    .HasColumnName("vltotalliquidado");

                entity.Property(e => e.Vltotalpago)
                    .HasColumnType("money")
                    .HasColumnName("vltotalpago");
            });

            modelBuilder.Entity<TbTmpEmpenhosPorOrgao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpEmpenhosPorOrgao");

                entity.Property(e => e.Cdorgao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdorgao")
                    .IsFixedLength();

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Nmorgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmorgao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Vlempenhado)
                    .HasColumnType("money")
                    .HasColumnName("vlempenhado");
            });

            modelBuilder.Entity<TbTmpFuncaoSubFuncao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpFuncaoSubFuncao");

                entity.Property(e => e.Cdfuncao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdfuncao")
                    .IsFixedLength();

                entity.Property(e => e.Cdsubfuncao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdsubfuncao")
                    .IsFixedLength();

                entity.Property(e => e.Dsfuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsfuncao");

                entity.Property(e => e.Dssubfuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dssubfuncao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Vlatualizado)
                    .HasColumnType("money")
                    .HasColumnName("vlatualizado");

                entity.Property(e => e.Vlempenhoateperiodo)
                    .HasColumnType("money")
                    .HasColumnName("vlempenhoateperiodo");

                entity.Property(e => e.Vlempenhoperiodo)
                    .HasColumnType("money")
                    .HasColumnName("vlempenhoperiodo");

                entity.Property(e => e.Vlliquidadoateperiodo)
                    .HasColumnType("money")
                    .HasColumnName("vlliquidadoateperiodo");

                entity.Property(e => e.Vlliquidadoperiodo)
                    .HasColumnType("money")
                    .HasColumnName("vlliquidadoperiodo");

                entity.Property(e => e.Vlorcado)
                    .HasColumnType("money")
                    .HasColumnName("vlorcado");
            });

            modelBuilder.Entity<TbTmpReceitaArrecadadum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpReceitaArrecadada");

                entity.Property(e => e.Cdreceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdreceita");

                entity.Property(e => e.Dsreceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsreceita");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Idreceita).HasColumnName("idreceita");

                entity.Property(e => e.Idreceitanivelsuper).HasColumnName("idreceitanivelsuper");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Vlarrecadado)
                    .HasColumnType("money")
                    .HasColumnName("vlarrecadado");

                entity.Property(e => e.Vlorcado)
                    .HasColumnType("money")
                    .HasColumnName("vlorcado");
            });

            modelBuilder.Entity<TbTmpRmsAprovadasOrgao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpRmsAprovadasOrgao");

                entity.Property(e => e.Cdorgao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdorgao")
                    .IsFixedLength();

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Nmorgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmorgao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Vltotalrms)
                    .HasColumnType("money")
                    .HasColumnName("vltotalrms");
            });

            modelBuilder.Entity<Tmp50MaioresCredores2012>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp50MaioresCredores2012");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Nmpessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmpessoa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Nrcnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrcnpjcpf");

                entity.Property(e => e.Vlempenho)
                    .HasColumnType("money")
                    .HasColumnName("vlempenho");

                entity.Property(e => e.Vlliquidado)
                    .HasColumnType("money")
                    .HasColumnName("vlliquidado");

                entity.Property(e => e.Vlpago)
                    .HasColumnType("money")
                    .HasColumnName("vlpago");
            });

            modelBuilder.Entity<Tmp50MaioresCredores2015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp50MaioresCredores2015");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Nmpessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmpessoa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Nrcnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrcnpjcpf");

                entity.Property(e => e.Vlempenho)
                    .HasColumnType("money")
                    .HasColumnName("vlempenho");

                entity.Property(e => e.Vlliquidado)
                    .HasColumnType("money")
                    .HasColumnName("vlliquidado");

                entity.Property(e => e.Vlpago)
                    .HasColumnType("money")
                    .HasColumnName("vlpago");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
