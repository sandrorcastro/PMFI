using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class GIIGAlvaraConstrucaoDBContext : DbContext
    {
        public GIIGAlvaraConstrucaoDBContext()
        {
        }

        public GIIGAlvaraConstrucaoDBContext(DbContextOptions<GIIGAlvaraConstrucaoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SystTblControle> SystTblControles { get; set; } = null!;
        public virtual DbSet<TabCidade> TabCidades { get; set; } = null!;
        public virtual DbSet<TabPessoa> TabPessoas { get; set; } = null!;
        public virtual DbSet<TabSolicitacaoArquivo> TabSolicitacaoArquivos { get; set; } = null!;
        public virtual DbSet<TabSolicitacaoAtividade> TabSolicitacaoAtividades { get; set; } = null!;
        public virtual DbSet<TabSolicitacaoTaxa> TabSolicitacaoTaxas { get; set; } = null!;
        public virtual DbSet<TabSolicitaco> TabSolicitacoes { get; set; } = null!;
        public virtual DbSet<TabUsuario> TabUsuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGAlvaraConstrucaoDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<SystTblControle>(entity =>
            {
                entity.HasKey(e => new { e.Sttabela, e.Nuano });

                entity.ToTable("SYST_TBL_CONTROLE");

                entity.Property(e => e.Sttabela)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STTABELA");

                entity.Property(e => e.Nuano).HasColumnName("NUANO");

                entity.Property(e => e.Nucodigo).HasColumnName("NUCODIGO");
            });

            modelBuilder.Entity<TabCidade>(entity =>
            {
                entity.HasKey(e => e.CidaId);

                entity.ToTable("tabCidade");

                entity.Property(e => e.CidaId)
                    .ValueGeneratedNever()
                    .HasColumnName("cidaId");

                entity.Property(e => e.CidaNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cidaNome");

                entity.Property(e => e.CidaUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cidaUF")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TabPessoa>(entity =>
            {
                entity.HasKey(e => e.PessId)
                    .HasName("PK_tabRequerente");

                entity.ToTable("tabPessoa");

                entity.Property(e => e.PessId)
                    .ValueGeneratedNever()
                    .HasColumnName("pessId");

                entity.Property(e => e.CidaId).HasColumnName("cidaId");

                entity.Property(e => e.PessBairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessBairro");

                entity.Property(e => e.PessCep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("pessCEP");

                entity.Property(e => e.PessComplemento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pessComplemento");

                entity.Property(e => e.PessCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("pessCPFCNPJ");

                entity.Property(e => e.PessCrea)
                    .HasMaxLength(15)
                    .HasColumnName("pessCrea")
                    .IsFixedLength();

                entity.Property(e => e.PessEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessEmail");

                entity.Property(e => e.PessInscricaoMunicipal)
                    .HasMaxLength(10)
                    .HasColumnName("pessInscricaoMunicipal")
                    .IsFixedLength();

                entity.Property(e => e.PessLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessLogradouro");

                entity.Property(e => e.PessNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessNome");

                entity.Property(e => e.PessNomeMae)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessNomeMae");

                entity.Property(e => e.PessNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pessNumero");

                entity.Property(e => e.PessProfissao)
                    .HasMaxLength(100)
                    .HasColumnName("pessProfissao")
                    .IsFixedLength();

                entity.Property(e => e.PessTelefone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pessTelefone");

                entity.Property(e => e.PessTipo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pessTipo")
                    .IsFixedLength();

                entity.Property(e => e.PessTipoLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessTipoLogradouro");

                entity.HasOne(d => d.Cida)
                    .WithMany(p => p.TabPessoas)
                    .HasForeignKey(d => d.CidaId)
                    .HasConstraintName("FK_tabRequerente_tabCidade");
            });

            modelBuilder.Entity<TabSolicitacaoArquivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabSolicitacaoArquivo");

                entity.Property(e => e.SoarArquivo).HasColumnName("soarArquivo");

                entity.Property(e => e.SoliId).HasColumnName("soliId");

                entity.HasOne(d => d.Soli)
                    .WithMany()
                    .HasForeignKey(d => d.SoliId)
                    .HasConstraintName("FK_tabSolicitacaoArquivo_tabSolicitacoes");
            });

            modelBuilder.Entity<TabSolicitacaoAtividade>(entity =>
            {
                entity.HasKey(e => e.SolaId);

                entity.ToTable("tabSolicitacaoAtividade");

                entity.Property(e => e.SolaId)
                    .ValueGeneratedNever()
                    .HasColumnName("solaId");

                entity.Property(e => e.SolaCnae)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("solaCnae");

                entity.Property(e => e.SolaDescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("solaDescricao");

                entity.Property(e => e.SolaSiglaZoneamento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("solaSiglaZoneamento");

                entity.Property(e => e.SoliId).HasColumnName("soliId");

                entity.HasOne(d => d.Soli)
                    .WithMany(p => p.TabSolicitacaoAtividades)
                    .HasForeignKey(d => d.SoliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabSolicitacaoAtividade_tabSolicitacoes");
            });

            modelBuilder.Entity<TabSolicitacaoTaxa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabSolicitacaoTaxa");

                entity.Property(e => e.SoliId).HasColumnName("soliId");

                entity.Property(e => e.SotaDataPgto)
                    .HasMaxLength(10)
                    .HasColumnName("sotaDataPgto")
                    .IsFixedLength();

                entity.Property(e => e.SotaSituacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sotaSituacao");

                entity.Property(e => e.SotaValorPago)
                    .HasColumnType("money")
                    .HasColumnName("sotaValorPago");

                entity.Property(e => e.TipoTribNome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoTribNome");

                entity.HasOne(d => d.Soli)
                    .WithMany()
                    .HasForeignKey(d => d.SoliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabSolicitacaoTaxa_tabSolicitacoes");
            });

            modelBuilder.Entity<TabSolicitaco>(entity =>
            {
                entity.HasKey(e => e.SoliId);

                entity.ToTable("tabSolicitacoes");

                entity.Property(e => e.SoliId)
                    .ValueGeneratedNever()
                    .HasColumnName("soliId");

                entity.Property(e => e.PessId).HasColumnName("pessId");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.Property(e => e.SoliAreaConstrucao)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("soliAreaConstrucao");

                entity.Property(e => e.SoliData)
                    .HasColumnType("datetime")
                    .HasColumnName("soliData");

                entity.Property(e => e.SoliInscricaoImobiliaria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("soliInscricaoImobiliaria");

                entity.Property(e => e.ZousId).HasColumnName("zousID");

                entity.Property(e => e.ZozoId).HasColumnName("zozoId");

                entity.HasOne(d => d.Pess)
                    .WithMany(p => p.TabSolicitacos)
                    .HasForeignKey(d => d.PessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabSolicitacoes_tabPessoa");
            });

            modelBuilder.Entity<TabUsuario>(entity =>
            {
                entity.HasKey(e => e.UsuaId);

                entity.ToTable("tabUsuarios");

                entity.Property(e => e.UsuaId)
                    .ValueGeneratedNever()
                    .HasColumnName("usuaId");

                entity.Property(e => e.PessId).HasColumnName("pessId");

                entity.Property(e => e.UsuSituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("usuSituacao")
                    .IsFixedLength();

                entity.Property(e => e.UsuaSenha)
                    .HasMaxLength(30)
                    .HasColumnName("usuaSenha")
                    .IsFixedLength();

                entity.HasOne(d => d.Pess)
                    .WithMany(p => p.TabUsuarios)
                    .HasForeignKey(d => d.PessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabUsuarios_tabPessoa");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
