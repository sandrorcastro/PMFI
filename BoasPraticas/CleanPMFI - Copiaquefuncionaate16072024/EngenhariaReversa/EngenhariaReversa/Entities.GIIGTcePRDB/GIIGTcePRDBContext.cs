using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class GIIGTcePRDBContext : DbContext
    {
        public GIIGTcePRDBContext()
        {
        }

        public GIIGTcePRDBContext(DbContextOptions<GIIGTcePRDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbDivDiarioArrecadacao> TbDivDiarioArrecadacaos { get; set; } = null!;
        public virtual DbSet<TbDivDiarioArrecadacaoEstorno> TbDivDiarioArrecadacaoEstornos { get; set; } = null!;
        public virtual DbSet<TbDivLancamentoAtualizacaoCreditoEstorno> TbDivLancamentoAtualizacaoCreditoEstornos { get; set; } = null!;
        public virtual DbSet<TbDivLancamentoAtualizacaoMonetariaCredito> TbDivLancamentoAtualizacaoMonetariaCreditos { get; set; } = null!;
        public virtual DbSet<TbDivLancamentoCredito> TbDivLancamentoCreditos { get; set; } = null!;
        public virtual DbSet<TbDivLancamentoCreditoComposicao> TbDivLancamentoCreditoComposicaos { get; set; } = null!;
        public virtual DbSet<TbDivLancamentoCreditoEstorno> TbDivLancamentoCreditoEstornos { get; set; } = null!;
        public virtual DbSet<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; } = null!;
        public virtual DbSet<TbDivLancamentoDeducaoCreditoEstorno> TbDivLancamentoDeducaoCreditoEstornos { get; set; } = null!;
        public virtual DbSet<TbDivTiposCredito> TbDivTiposCreditos { get; set; } = null!;
        public virtual DbSet<TbDspTipoCategoriaObjetoDespesa> TbDspTipoCategoriaObjetoDespesas { get; set; } = null!;
        public virtual DbSet<TbDspTipoObjetoDespesa> TbDspTipoObjetoDespesas { get; set; } = null!;
        public virtual DbSet<TbGerBaixaResponsavelModulo> TbGerBaixaResponsavelModulos { get; set; } = null!;
        public virtual DbSet<TbGerEmpresasGoverno> TbGerEmpresasGovernos { get; set; } = null!;
        public virtual DbSet<TbGerEscopo> TbGerEscopos { get; set; } = null!;
        public virtual DbSet<TbGerLeiAto> TbGerLeiAtos { get; set; } = null!;
        public virtual DbSet<TbGerPublicacaoOrgaoOficial> TbGerPublicacaoOrgaoOficials { get; set; } = null!;
        public virtual DbSet<TbGerResponsavelModulo> TbGerResponsavelModulos { get; set; } = null!;
        public virtual DbSet<TbGerTipoArrecadacao> TbGerTipoArrecadacaos { get; set; } = null!;
        public virtual DbSet<TbGerTipoAtualizacaoCredito> TbGerTipoAtualizacaoCreditos { get; set; } = null!;
        public virtual DbSet<TbGerTipoDeducaoCredito> TbGerTipoDeducaoCreditos { get; set; } = null!;
        public virtual DbSet<TbGerTipoDocumentoLeiAto> TbGerTipoDocumentoLeiAtos { get; set; } = null!;
        public virtual DbSet<TbGerTipoDocumentoPessoa> TbGerTipoDocumentoPessoas { get; set; } = null!;
        public virtual DbSet<TbGerTipoDocumentoXescopo> TbGerTipoDocumentoXescopos { get; set; } = null!;
        public virtual DbSet<TbGerTipoModulo> TbGerTipoModulos { get; set; } = null!;
        public virtual DbSet<TbGerTipoNaturezaCredito> TbGerTipoNaturezaCreditos { get; set; } = null!;
        public virtual DbSet<TbGerTipoOperacaoCredito> TbGerTipoOperacaoCreditos { get; set; } = null!;
        public virtual DbSet<TbGerTipoOrigemReceitum> TbGerTipoOrigemReceita { get; set; } = null!;
        public virtual DbSet<TbGerTipoResponsavelModulo> TbGerTipoResponsavelModulos { get; set; } = null!;
        public virtual DbSet<TbGerUnidadesMedidum> TbGerUnidadesMedida { get; set; } = null!;
        public virtual DbSet<TbOrcAplicacaoRecurso> TbOrcAplicacaoRecursos { get; set; } = null!;
        public virtual DbSet<TbOrcDesdobramentoFonte> TbOrcDesdobramentoFontes { get; set; } = null!;
        public virtual DbSet<TbOrcDetalhamentoFonte> TbOrcDetalhamentoFontes { get; set; } = null!;
        public virtual DbSet<TbOrcFontesCorrelacaoOrigen> TbOrcFontesCorrelacaoOrigens { get; set; } = null!;
        public virtual DbSet<TbOrcFontesGiiGcorrelacao> TbOrcFontesGiiGcorrelacaos { get; set; } = null!;
        public virtual DbSet<TbOrcFontesPadrao> TbOrcFontesPadraos { get; set; } = null!;
        public virtual DbSet<TbOrcOrigemRecurso> TbOrcOrigemRecursos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=GIIGTcePRDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbDivDiarioArrecadacao>(entity =>
            {
                entity.HasKey(e => e.IdArrecadacao);

                entity.ToTable("tbDivDiarioArrecadacao");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DtArrecadacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtArrecadacao");

                entity.Property(e => e.NrAnoArrecadacao).HasColumnName("nrAnoArrecadacao");

                entity.Property(e => e.NrAnoPlanoContas).HasColumnName("nrAnoPlanoContas");

                entity.Property(e => e.NrArrecadacao).HasColumnName("nrArrecadacao");

                entity.Property(e => e.NrDocContribuinte)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nrDocContribuinte");

                entity.Property(e => e.TpDocContribuinte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tpDocContribuinte");

                entity.Property(e => e.VlArrecadacao)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadacao");

                entity.HasOne(d => d.IdLancamentoNavigation)
                    .WithMany(p => p.TbDivDiarioArrecadacaos)
                    .HasForeignKey(d => d.IdLancamento)
                    .HasConstraintName("FK_tbDivDiarioArrecadacao_tbDivLctoCredito");

                entity.HasOne(d => d.IdTpArrecadacaoNavigation)
                    .WithMany(p => p.TbDivDiarioArrecadacaos)
                    .HasForeignKey(d => d.IdTpArrecadacao)
                    .HasConstraintName("FK_tbDivDiarioArrecadacao_tbGerTpArrecadacao");

                entity.HasOne(d => d.IdTpOrigemReceitaNavigation)
                    .WithMany(p => p.TbDivDiarioArrecadacaos)
                    .HasForeignKey(d => d.IdTpOrigemReceita)
                    .HasConstraintName("FK_tbDivDiarioArrecadacao_tbGerTpOrigemReceita");
            });

            modelBuilder.Entity<TbDivDiarioArrecadacaoEstorno>(entity =>
            {
                entity.HasKey(e => e.IdArrecadacaoEstorno);

                entity.ToTable("tbDivDiarioArrecadacaoEstorno");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DsMotivo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsMotivo");

                entity.Property(e => e.DtEstorno)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEstorno");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.NrAnoEstorno).HasColumnName("nrAnoEstorno");

                entity.Property(e => e.NrEstorno).HasColumnName("nrEstorno");

                entity.Property(e => e.VlOperacao)
                    .HasColumnType("money")
                    .HasColumnName("vlOperacao");

                entity.HasOne(d => d.IdArrecadacaoNavigation)
                    .WithMany(p => p.TbDivDiarioArrecadacaoEstornos)
                    .HasForeignKey(d => d.IdArrecadacao)
                    .HasConstraintName("FK_tbDivDiarioArrecadacaoEstorno_tbDivDiarioArrecadacao");
            });

            modelBuilder.Entity<TbDivLancamentoAtualizacaoCreditoEstorno>(entity =>
            {
                entity.HasKey(e => e.IdAtualizacaoEstorno)
                    .HasName("PK_tbDivLctoAtualizacaoCreditoEstorno");

                entity.ToTable("tbDivLancamentoAtualizacaoCreditoEstorno");

                entity.Property(e => e.DsMotivo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsMotivo");

                entity.Property(e => e.DtEstorno)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEstorno");

                entity.Property(e => e.NrAnoEstorno).HasColumnName("nrAnoEstorno");

                entity.Property(e => e.NrEstorno).HasColumnName("nrEstorno");

                entity.Property(e => e.VlEstorno)
                    .HasColumnType("money")
                    .HasColumnName("vlEstorno");

                entity.HasOne(d => d.IdAtualizacaoNavigation)
                    .WithMany(p => p.TbDivLancamentoAtualizacaoCreditoEstornos)
                    .HasForeignKey(d => d.IdAtualizacao)
                    .HasConstraintName("FK_tbDivLctoAtualizacaoCreditoEstorno_tbDivLctoAtualizacaoMonetariaCredito");

                entity.HasOne(d => d.IdLeiAtoNavigation)
                    .WithMany(p => p.TbDivLancamentoAtualizacaoCreditoEstornos)
                    .HasForeignKey(d => d.IdLeiAto)
                    .HasConstraintName("FK_tbDivLctoAtualizacaoCreditoEstorno_tbGerLeiAto");
            });

            modelBuilder.Entity<TbDivLancamentoAtualizacaoMonetariaCredito>(entity =>
            {
                entity.HasKey(e => e.IdAtualizacao)
                    .HasName("PK_tbDivLctoAtualizacaoMonetariaCredito");

                entity.ToTable("tbDivLancamentoAtualizacaoMonetariaCredito");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAtualizacao");

                entity.Property(e => e.NrAnoAtualizacao).HasColumnName("nrAnoAtualizacao");

                entity.Property(e => e.NrAtualizacao).HasColumnName("nrAtualizacao");

                entity.Property(e => e.VlAtualizacao)
                    .HasColumnType("money")
                    .HasColumnName("vlAtualizacao");

                entity.HasOne(d => d.IdLctoNavigation)
                    .WithMany(p => p.TbDivLancamentoAtualizacaoMonetariaCreditos)
                    .HasForeignKey(d => d.IdLcto)
                    .HasConstraintName("FK_tbDivLctoAtualizacaoMonetariaCredito_tbDivLctoCredito");

                entity.HasOne(d => d.IdLeiAtoNavigation)
                    .WithMany(p => p.TbDivLancamentoAtualizacaoMonetariaCreditos)
                    .HasForeignKey(d => d.IdLeiAto)
                    .HasConstraintName("FK_tbDivLctoAtualizacaoMonetariaCredito_tbGerLeiAto");

                entity.HasOne(d => d.IdTpAtualizacaoCreditoNavigation)
                    .WithMany(p => p.TbDivLancamentoAtualizacaoMonetariaCreditos)
                    .HasForeignKey(d => d.IdTpAtualizacaoCredito)
                    .HasConstraintName("FK_tbDivLctoAtualizacaoMonetariaCredito_tbGerTpAtualizacaoCredito");
            });

            modelBuilder.Entity<TbDivLancamentoCredito>(entity =>
            {
                entity.HasKey(e => e.IdLancamento)
                    .HasName("PK_tbDivLctoCredito");

                entity.ToTable("tbDivLancamentoCredito");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.DlLcto)
                    .HasColumnType("datetime")
                    .HasColumnName("dlLcto");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.NrAnoBase).HasColumnName("nrAnoBase");

                entity.Property(e => e.NrAnoCredito).HasColumnName("nrAnoCredito");

                entity.Property(e => e.NrCredito).HasColumnName("nrCredito");

                entity.Property(e => e.NrDocContribuinte)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nrDocContribuinte");

                entity.Property(e => e.NrMesBase).HasColumnName("nrMesBase");

                entity.Property(e => e.TpDocContribuinte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tpDocContribuinte");

                entity.Property(e => e.VlCredito)
                    .HasColumnType("money")
                    .HasColumnName("vlCredito");

                entity.HasOne(d => d.IdLeiAtoNavigation)
                    .WithMany(p => p.TbDivLancamentoCreditos)
                    .HasForeignKey(d => d.IdLeiAto)
                    .HasConstraintName("FK_tbDivLctoCredito_tbGerLeiAto");

                entity.HasOne(d => d.IdTpNatCreditoNavigation)
                    .WithMany(p => p.TbDivLancamentoCreditos)
                    .HasForeignKey(d => d.IdTpNatCredito)
                    .HasConstraintName("FK_tbDivLctoCredito_tbGerTpNatCredito");

                entity.HasOne(d => d.IdTpOpCreditoNavigation)
                    .WithMany(p => p.TbDivLancamentoCreditos)
                    .HasForeignKey(d => d.IdTpOpCredito)
                    .HasConstraintName("FK_tbDivLctoCredito_tbGerTpOpCredito");
            });

            modelBuilder.Entity<TbDivLancamentoCreditoComposicao>(entity =>
            {
                entity.HasKey(e => e.IdLctoComposicao)
                    .HasName("PK_tbDivLctoCreditoComposicao");

                entity.ToTable("tbDivLancamentoCreditoComposicao");

                entity.Property(e => e.FlUnica).HasColumnName("flUnica");

                entity.Property(e => e.IdTributo).HasColumnType("money");

                entity.Property(e => e.VlComposicao)
                    .HasColumnType("money")
                    .HasColumnName("vlComposicao");

                entity.HasOne(d => d.IdLancamentoNavigation)
                    .WithMany(p => p.TbDivLancamentoCreditoComposicaos)
                    .HasForeignKey(d => d.IdLancamento)
                    .HasConstraintName("FK_tbDivLctoCreditoComposicao_tbDivLctoCredito");
            });

            modelBuilder.Entity<TbDivLancamentoCreditoEstorno>(entity =>
            {
                entity.HasKey(e => e.IdEstono)
                    .HasName("PK_tbDivLctoCreditoEstorno");

                entity.ToTable("tbDivLancamentoCreditoEstorno");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DsMotivo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsMotivo");

                entity.Property(e => e.DtEstono)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEstono");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.NrAnoEstorno).HasColumnName("nrAnoEstorno");

                entity.Property(e => e.NrEstono).HasColumnName("nrEstono");

                entity.Property(e => e.VlEstorno)
                    .HasColumnType("money")
                    .HasColumnName("vlEstorno");

                entity.HasOne(d => d.IdLancamentoNavigation)
                    .WithMany(p => p.TbDivLancamentoCreditoEstornos)
                    .HasForeignKey(d => d.IdLancamento)
                    .HasConstraintName("FK_tbDivLctoCreditoEstorno_tbDivLctoCredito");

                entity.HasOne(d => d.IdLeiAtoNavigation)
                    .WithMany(p => p.TbDivLancamentoCreditoEstornos)
                    .HasForeignKey(d => d.IdLeiAto)
                    .HasConstraintName("FK_tbDivLctoCreditoEstorno_tbGerLeiAto");
            });

            modelBuilder.Entity<TbDivLancamentoDeducaoCredito>(entity =>
            {
                entity.HasKey(e => e.IdDeducao)
                    .HasName("PK_tbDivLctoDeducaoCredito");

                entity.ToTable("tbDivLancamentoDeducaoCredito");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DsMotivo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsMotivo");

                entity.Property(e => e.DtDeducao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDeducao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.NrAnoDeducao).HasColumnName("nrAnoDeducao");

                entity.Property(e => e.NrDeducao).HasColumnName("nrDeducao");

                entity.Property(e => e.VlDeducao)
                    .HasColumnType("money")
                    .HasColumnName("vlDeducao");

                entity.HasOne(d => d.IdLctoNavigation)
                    .WithMany(p => p.TbDivLancamentoDeducaoCreditos)
                    .HasForeignKey(d => d.IdLcto)
                    .HasConstraintName("FK_tbDivLctoDeducaoCredito_tbDivLctoCredito");

                entity.HasOne(d => d.IdLeiAtoNavigation)
                    .WithMany(p => p.TbDivLancamentoDeducaoCreditos)
                    .HasForeignKey(d => d.IdLeiAto)
                    .HasConstraintName("FK_tbDivLctoDeducaoCredito_tbGerLeiAto");

                entity.HasOne(d => d.IdTpDeducaoCreditoNavigation)
                    .WithMany(p => p.TbDivLancamentoDeducaoCreditos)
                    .HasForeignKey(d => d.IdTpDeducaoCredito)
                    .HasConstraintName("FK_tbDivLctoDeducaoCredito_tbGerTpDeducaoCredito");
            });

            modelBuilder.Entity<TbDivLancamentoDeducaoCreditoEstorno>(entity =>
            {
                entity.HasKey(e => e.IdDeducaoEstorno)
                    .HasName("PK_tbDivLctoDeducaoCreditoEstorno");

                entity.ToTable("tbDivLancamentoDeducaoCreditoEstorno");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DsMotivo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsMotivo");

                entity.Property(e => e.DtEstorno)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEstorno");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.NrAnoEstorno).HasColumnName("nrAnoEstorno");

                entity.Property(e => e.NrEstorno).HasColumnName("nrEstorno");

                entity.Property(e => e.VlEstono)
                    .HasColumnType("money")
                    .HasColumnName("vlEstono");

                entity.HasOne(d => d.IdDeducaoNavigation)
                    .WithMany(p => p.TbDivLancamentoDeducaoCreditoEstornos)
                    .HasForeignKey(d => d.IdDeducao)
                    .HasConstraintName("FK_tbDivLctoDeducaoCreditoEstorno_tbDivLctoDeducaoCredito");

                entity.HasOne(d => d.IdLeitAtoNavigation)
                    .WithMany(p => p.TbDivLancamentoDeducaoCreditoEstornos)
                    .HasForeignKey(d => d.IdLeitAto)
                    .HasConstraintName("FK_tbDivLctoDeducaoCreditoEstorno_tbGerLeiAto");
            });

            modelBuilder.Entity<TbDivTiposCredito>(entity =>
            {
                entity.HasKey(e => e.IdTipoCredito);

                entity.ToTable("tbDivTiposCreditos");

                entity.Property(e => e.IdTipoCredito)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoCredito");

                entity.Property(e => e.DsTipoCredito)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoCredito");

                entity.Property(e => e.FlTributo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flTributo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbDspTipoCategoriaObjetoDespesa>(entity =>
            {
                entity.HasKey(e => e.IdTipoCategoria)
                    .HasName("PK_tbTceTipoCategoriaObjetoDespesa");

                entity.ToTable("tbDspTipoCategoriaObjetoDespesa");

                entity.Property(e => e.IdTipoCategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoCategoria");

                entity.Property(e => e.DsTipoCategoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoCategoria");
            });

            modelBuilder.Entity<TbDspTipoObjetoDespesa>(entity =>
            {
                entity.HasKey(e => e.IdTipoObjetoDespesa)
                    .HasName("PK_tbTceTipoObjetoDespesa");

                entity.ToTable("tbDspTipoObjetoDespesa");

                entity.Property(e => e.IdTipoObjetoDespesa)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoObjetoDespesa");

                entity.Property(e => e.DsTipoObjetoDespesa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoObjetoDespesa");

                entity.Property(e => e.IdTipoCategoria).HasColumnName("idTipoCategoria");

                entity.HasOne(d => d.IdTipoCategoriaNavigation)
                    .WithMany(p => p.TbDspTipoObjetoDespesas)
                    .HasForeignKey(d => d.IdTipoCategoria)
                    .HasConstraintName("FK_tbTceTipoObjetoDespesa_tbTceTipoCategoriaObjetoDespesa");
            });

            modelBuilder.Entity<TbGerBaixaResponsavelModulo>(entity =>
            {
                entity.HasKey(e => e.IdBaixa);

                entity.ToTable("tbGerBaixaResponsavelModulo");

                entity.Property(e => e.IdBaixa).HasColumnName("idBaixa");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsMotivo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsMotivo");

                entity.Property(e => e.DtBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("dtBaixa");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdResponsavel).HasColumnName("idResponsavel");

                entity.HasOne(d => d.IdResponsavelNavigation)
                    .WithMany(p => p.TbGerBaixaResponsavelModulos)
                    .HasForeignKey(d => d.IdResponsavel)
                    .HasConstraintName("FK_tbGerBaixaResponsavelModulo_tbGerResponsavelModulo");
            });

            modelBuilder.Entity<TbGerEmpresasGoverno>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("tbGerEmpresasGoverno");

                entity.Property(e => e.IdEmpresa)
                    .ValueGeneratedNever()
                    .HasColumnName("idEmpresa");

                entity.Property(e => e.CdTce).HasColumnName("cdTCE");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");
            });

            modelBuilder.Entity<TbGerEscopo>(entity =>
            {
                entity.HasKey(e => e.IdEscopo);

                entity.ToTable("tbGerEscopo");

                entity.Property(e => e.IdEscopo)
                    .ValueGeneratedNever()
                    .HasColumnName("idEscopo");

                entity.Property(e => e.DsEscopo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsEscopo");

                entity.Property(e => e.FlPlurianual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flPlurianual")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbGerLeiAto>(entity =>
            {
                entity.HasKey(e => e.IdLeiAto)
                    .HasName("PK_tbGerLei");

                entity.ToTable("tbGerLeiAto");

                entity.HasIndex(e => new { e.IdTipoDocumento, e.NrAnoLeiAto, e.FlSituacao }, "IX_tbGerLeiAto_idTipoDocumento_nrAnoLeiAto_flSituacao");

                entity.HasIndex(e => new { e.IdTipoDocumento, e.NrLeiAto, e.NrAnoLeiAto, e.FlSituacao }, "IX_tbGerLeiAto_idTipoDocumento_nrLeiAto_nrAnoLeiAto_flSituacao");

                entity.Property(e => e.IdLeiAto).HasColumnName("idLeiAto");

                entity.Property(e => e.CdControleDocumento).HasColumnName("cdControleDocumento");

                entity.Property(e => e.CdControleLeiAto).HasColumnName("cdControleLeiAto");

                entity.Property(e => e.DsLeiAto)
                    .IsUnicode(false)
                    .HasColumnName("dsLeiAto");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.DtLeiAto)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLeiAto");

                entity.Property(e => e.DtReferenciaTce)
                    .HasColumnType("datetime")
                    .HasColumnName("dtReferenciaTCE");

                entity.Property(e => e.FlImpotaTce).HasColumnName("flImpotaTCE");

                entity.Property(e => e.FlSituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flSituacao")
                    .IsFixedLength();

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdEscopo).HasColumnName("idEscopo");

                entity.Property(e => e.IdPessoaOrigem).HasColumnName("idPessoaOrigem");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.NrAnoInicialAplicacao).HasColumnName("nrAnoInicialAplicacao");

                entity.Property(e => e.NrAnoLeiAto).HasColumnName("nrAnoLeiAto");

                entity.Property(e => e.NrLeiAto).HasColumnName("nrLeiAto");

                entity.HasOne(d => d.IdEscopoNavigation)
                    .WithMany(p => p.TbGerLeiAtos)
                    .HasForeignKey(d => d.IdEscopo)
                    .HasConstraintName("FK_tbGerLeiAto_tbGerEscopo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.TbGerLeiAtos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .HasConstraintName("FK_tbGerLeiAto_tbGerTipoDocumentoLeiAto");
            });

            modelBuilder.Entity<TbGerPublicacaoOrgaoOficial>(entity =>
            {
                entity.HasKey(e => e.IdPublicacao);

                entity.ToTable("tbGerPublicacaoOrgaoOficial");

                entity.HasIndex(e => e.IdLeiAto, "IX_tbGerPublicacaoOrgaoOficial_idLeiAto");

                entity.Property(e => e.IdPublicacao).HasColumnName("idPublicacao");

                entity.Property(e => e.DtBaseTce)
                    .HasColumnType("datetime")
                    .HasColumnName("dtBaseTCE");

                entity.Property(e => e.DtPublicacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPublicacao");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdLeiAto).HasColumnName("idLeiAto");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrOrgaoOficial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nrOrgaoOficial");

                entity.Property(e => e.NrPagina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nrPagina");

                entity.HasOne(d => d.IdLeiAtoNavigation)
                    .WithMany(p => p.TbGerPublicacaoOrgaoOficials)
                    .HasForeignKey(d => d.IdLeiAto)
                    .HasConstraintName("FK_tbGerPublicacaoOrgaoOficial_tbGerLeiAto");
            });

            modelBuilder.Entity<TbGerResponsavelModulo>(entity =>
            {
                entity.HasKey(e => e.IdResponsavel);

                entity.ToTable("tbGerResponsavelModulo");

                entity.Property(e => e.IdResponsavel).HasColumnName("idResponsavel");

                entity.Property(e => e.CdOperacao).HasColumnName("cdOperacao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.DtInicioVinculo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioVinculo");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.IdTipoModulo).HasColumnName("idTipoModulo");

                entity.Property(e => e.IdTipoResponsavel).HasColumnName("idTipoResponsavel");

                entity.Property(e => e.NmResponsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmResponsavel");

                entity.Property(e => e.NrDocumento)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nrDocumento");

                entity.Property(e => e.NrEnderecoIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nrEnderecoIP");
            });

            modelBuilder.Entity<TbGerTipoArrecadacao>(entity =>
            {
                entity.HasKey(e => e.IdTpArrecadacao)
                    .HasName("PK_tbGerTpArrecadacao");

                entity.ToTable("tbGerTipoArrecadacao");

                entity.Property(e => e.IdTpArrecadacao).ValueGeneratedNever();

                entity.Property(e => e.DsTpArrecadacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTpArrecadacao");
            });

            modelBuilder.Entity<TbGerTipoAtualizacaoCredito>(entity =>
            {
                entity.HasKey(e => e.IdTpAtualizacaoCredito)
                    .HasName("PK_tbGerTpAtualizacaoCredito");

                entity.ToTable("tbGerTipoAtualizacaoCredito");

                entity.Property(e => e.IdTpAtualizacaoCredito).ValueGeneratedNever();

                entity.Property(e => e.DsTpAtualizacaoCredito)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTpAtualizacaoCredito");
            });

            modelBuilder.Entity<TbGerTipoDeducaoCredito>(entity =>
            {
                entity.HasKey(e => e.IdTpDeducaoCredito)
                    .HasName("PK_tbGerTpDeducaoCredito");

                entity.ToTable("tbGerTipoDeducaoCredito");

                entity.Property(e => e.IdTpDeducaoCredito).ValueGeneratedNever();

                entity.Property(e => e.DsTpDeducaoCredito)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTpDeducaoCredito");
            });

            modelBuilder.Entity<TbGerTipoDocumentoLeiAto>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento)
                    .HasName("PK_tbGerTipoDocumento");

                entity.ToTable("tbGerTipoDocumentoLeiAto");

                entity.Property(e => e.IdTipoDocumento)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoDocumento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoDocumento");

                entity.Property(e => e.FlExigeNumeroDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flExigeNumeroDocumento")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbGerTipoDocumentoPessoa>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.ToTable("tbGerTipoDocumentoPessoa");

                entity.Property(e => e.IdTipoDocumento)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoDocumento");

                entity.Property(e => e.DsTipoDocumento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoDocumento");

                entity.Property(e => e.FlExigeUf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flExigeUF")
                    .IsFixedLength();

                entity.Property(e => e.FlExigeValidade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flExigeValidade")
                    .IsFixedLength();

                entity.Property(e => e.SgTipoDocumento)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sgTipoDocumento");
            });

            modelBuilder.Entity<TbGerTipoDocumentoXescopo>(entity =>
            {
                entity.HasKey(e => new { e.IdTipoDocumento, e.IdEscopo });

                entity.ToTable("tbGerTipoDocumentoXEscopo");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.IdEscopo).HasColumnName("idEscopo");

                entity.Property(e => e.DsEscopo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsEscopo");

                entity.HasOne(d => d.IdEscopoNavigation)
                    .WithMany(p => p.TbGerTipoDocumentoXescopos)
                    .HasForeignKey(d => d.IdEscopo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbGerTipoDocumentoXEscopo_tbGerEscopo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.TbGerTipoDocumentoXescopos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbGerTipoDocumentoXEscopo_tbGerTipoDocumentoLeiAto");
            });

            modelBuilder.Entity<TbGerTipoModulo>(entity =>
            {
                entity.HasKey(e => e.IdTipoModulo);

                entity.ToTable("tbGerTipoModulo");

                entity.Property(e => e.IdTipoModulo)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoModulo");

                entity.Property(e => e.DsTipoModulo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoModulo");
            });

            modelBuilder.Entity<TbGerTipoNaturezaCredito>(entity =>
            {
                entity.HasKey(e => e.IdTpNatCredito)
                    .HasName("PK_tbGerTpNatCredito");

                entity.ToTable("tbGerTipoNaturezaCredito");

                entity.Property(e => e.IdTpNatCredito).ValueGeneratedNever();

                entity.Property(e => e.DsTpNatCredito)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTpNatCredito");
            });

            modelBuilder.Entity<TbGerTipoOperacaoCredito>(entity =>
            {
                entity.HasKey(e => e.IdTpOpCredito)
                    .HasName("PK_tbGerTpOpCredito");

                entity.ToTable("tbGerTipoOperacaoCredito");

                entity.Property(e => e.IdTpOpCredito).ValueGeneratedNever();

                entity.Property(e => e.DsTpOpCredito)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTpOpCredito");
            });

            modelBuilder.Entity<TbGerTipoOrigemReceitum>(entity =>
            {
                entity.HasKey(e => e.IdTpOrigemReceita)
                    .HasName("PK_tbGerTpOrigemReceita");

                entity.ToTable("tbGerTipoOrigemReceita");

                entity.Property(e => e.IdTpOrigemReceita).ValueGeneratedNever();

                entity.Property(e => e.DsTpOrigemReceita)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTpOrigemReceita");
            });

            modelBuilder.Entity<TbGerTipoResponsavelModulo>(entity =>
            {
                entity.HasKey(e => e.IdTipoResponsavel);

                entity.ToTable("tbGerTipoResponsavelModulo");

                entity.Property(e => e.IdTipoResponsavel)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoResponsavel");

                entity.Property(e => e.DsTipoResponsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoResponsavel");
            });

            modelBuilder.Entity<TbGerUnidadesMedidum>(entity =>
            {
                entity.HasKey(e => e.IdUnidadeMedida);

                entity.ToTable("tbGerUnidadesMedida");

                entity.Property(e => e.IdUnidadeMedida)
                    .ValueGeneratedNever()
                    .HasColumnName("idUnidadeMedida");

                entity.Property(e => e.DsUnidadeMedida)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsUnidadeMedida");
            });

            modelBuilder.Entity<TbOrcAplicacaoRecurso>(entity =>
            {
                entity.HasKey(e => e.CdAplicacao);

                entity.ToTable("tbOrcAplicacaoRecursos");

                entity.Property(e => e.CdAplicacao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdAplicacao")
                    .IsFixedLength();

                entity.Property(e => e.DsAplicacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsAplicacao");
            });

            modelBuilder.Entity<TbOrcDesdobramentoFonte>(entity =>
            {
                entity.HasKey(e => e.CdDesdobramento);

                entity.ToTable("tbOrcDesdobramentoFontes");

                entity.Property(e => e.CdDesdobramento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdDesdobramento")
                    .IsFixedLength();

                entity.Property(e => e.DsDesdobramento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsDesdobramento");
            });

            modelBuilder.Entity<TbOrcDetalhamentoFonte>(entity =>
            {
                entity.HasKey(e => e.CdDetalhamento);

                entity.ToTable("tbOrcDetalhamentoFontes");

                entity.Property(e => e.CdDetalhamento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdDetalhamento")
                    .IsFixedLength();

                entity.Property(e => e.DsDetalhamento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsDetalhamento");
            });

            modelBuilder.Entity<TbOrcFontesCorrelacaoOrigen>(entity =>
            {
                entity.HasKey(e => e.IdCorrelacao);

                entity.ToTable("tbOrcFontesCorrelacaoOrigens");

                entity.Property(e => e.IdCorrelacao).HasColumnName("idCorrelacao");

                entity.Property(e => e.CdAplicacao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdAplicacao")
                    .IsFixedLength();

                entity.Property(e => e.CdDesdobramento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdDesdobramento")
                    .IsFixedLength();

                entity.Property(e => e.CdDetalhamento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdDetalhamento")
                    .IsFixedLength();

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdOrigem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdOrigem")
                    .IsFixedLength();

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.HasOne(d => d.CdAplicacaoNavigation)
                    .WithMany(p => p.TbOrcFontesCorrelacaoOrigens)
                    .HasForeignKey(d => d.CdAplicacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbOrcFontesCorrelacaoOrigens_tbOrcAplicacaoRecursos");

                entity.HasOne(d => d.CdDesdobramentoNavigation)
                    .WithMany(p => p.TbOrcFontesCorrelacaoOrigens)
                    .HasForeignKey(d => d.CdDesdobramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbOrcFontesCorrelacaoOrigens_tbOrcDesdobramentoFontes");

                entity.HasOne(d => d.CdDetalhamentoNavigation)
                    .WithMany(p => p.TbOrcFontesCorrelacaoOrigens)
                    .HasForeignKey(d => d.CdDetalhamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbOrcFontesCorrelacaoOrigens_tbOrcDetalhamentoFontes");

                entity.HasOne(d => d.CdOrigemNavigation)
                    .WithMany(p => p.TbOrcFontesCorrelacaoOrigens)
                    .HasForeignKey(d => d.CdOrigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbOrcFontesCorrelacaoOrigens_tbOrcOrigemRecursos");

                entity.HasOne(d => d.TbOrcFontesPadrao)
                    .WithMany(p => p.TbOrcFontesCorrelacaoOrigens)
                    .HasForeignKey(d => new { d.NrAno, d.CdFonte })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbOrcFontesCorrelacaoOrigens_tbOrcFontesPadrao");
            });

            modelBuilder.Entity<TbOrcFontesGiiGcorrelacao>(entity =>
            {
                entity.HasKey(e => new { e.IdFonte, e.IdCorrelacao });

                entity.ToTable("tbOrcFontesGiiGCorrelacao");

                entity.Property(e => e.IdFonte).HasColumnName("idFonte");

                entity.Property(e => e.IdCorrelacao).HasColumnName("idCorrelacao");

                entity.HasOne(d => d.IdCorrelacaoNavigation)
                    .WithMany(p => p.TbOrcFontesGiiGcorrelacaos)
                    .HasForeignKey(d => d.IdCorrelacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbOrcFontesGiiGCorrelacao_tbOrcFontesCorrelacaoOrigens");
            });

            modelBuilder.Entity<TbOrcFontesPadrao>(entity =>
            {
                entity.HasKey(e => new { e.NrAno, e.CdFonte });

                entity.ToTable("tbOrcFontesPadrao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.DsFontePadrao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("dsFontePadrao");

                entity.Property(e => e.FlPermiteDesdobra)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flPermiteDesdobra")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbOrcOrigemRecurso>(entity =>
            {
                entity.HasKey(e => e.CdOrigem);

                entity.ToTable("tbOrcOrigemRecursos");

                entity.Property(e => e.CdOrigem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdOrigem")
                    .IsFixedLength();

                entity.Property(e => e.DsOrigem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsOrigem");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
