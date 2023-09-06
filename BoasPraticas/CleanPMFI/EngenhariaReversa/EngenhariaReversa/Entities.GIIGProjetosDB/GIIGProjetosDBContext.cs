using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class GIIGProjetosDBContext : DbContext
    {
        public GIIGProjetosDBContext()
        {
        }

        public GIIGProjetosDBContext(DbContextOptions<GIIGProjetosDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAvaProjetosCriterio> TbAvaProjetosCriterios { get; set; } = null!;
        public virtual DbSet<TbAvaProjetosStatus> TbAvaProjetosStatuses { get; set; } = null!;
        public virtual DbSet<TbMapObjetivo> TbMapObjetivos { get; set; } = null!;
        public virtual DbSet<TbMapObjetivosGlobai> TbMapObjetivosGlobais { get; set; } = null!;
        public virtual DbSet<TbMapObjetivosMacro> TbMapObjetivosMacros { get; set; } = null!;
        public virtual DbSet<TbMapObjetivosPlanejamento> TbMapObjetivosPlanejamentos { get; set; } = null!;
        public virtual DbSet<TbMapVerso> TbMapVersoes { get; set; } = null!;
        public virtual DbSet<TbMapVersoesValore> TbMapVersoesValores { get; set; } = null!;
        public virtual DbSet<TbPrjCriterio> TbPrjCriterios { get; set; } = null!;
        public virtual DbSet<TbPrjCriteriosPeso> TbPrjCriteriosPesos { get; set; } = null!;
        public virtual DbSet<TbPrjEscala> TbPrjEscalas { get; set; } = null!;
        public virtual DbSet<TbPrjEscalaCriterio> TbPrjEscalaCriterios { get; set; } = null!;
        public virtual DbSet<TbPrjEscalaIten> TbPrjEscalaItens { get; set; } = null!;
        public virtual DbSet<TbPrjProjeto> TbPrjProjetos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGProjetosDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<TbAvaProjetosCriterio>(entity =>
            {
                entity.HasKey(e => new { e.IdProjeto, e.IdCriterio });

                entity.ToTable("tbAvaProjetosCriterios");

                entity.Property(e => e.IdProjeto).HasColumnName("idProjeto");

                entity.Property(e => e.IdCriterio).HasColumnName("idCriterio");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsLoginUltimaAlteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginUltimaAlteracao");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.DtCadastroUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastroUltimaAlteracao");

                entity.Property(e => e.IdCriterioPeso).HasColumnName("idCriterioPeso");

                entity.HasOne(d => d.IdCriterioNavigation)
                    .WithMany(p => p.TbAvaProjetosCriterios)
                    .HasForeignKey(d => d.IdCriterio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbAvaProjetosCriterios_tbPrjCriterios");

                entity.HasOne(d => d.IdCriterioPesoNavigation)
                    .WithMany(p => p.TbAvaProjetosCriterios)
                    .HasForeignKey(d => d.IdCriterioPeso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbAvaProjetosCriterios_tbPrjCriteriosPesos");

                entity.HasOne(d => d.IdProjetoNavigation)
                    .WithMany(p => p.TbAvaProjetosCriterios)
                    .HasForeignKey(d => d.IdProjeto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbAvaProjetosCriterios_tbPrjProjetos");
            });

            modelBuilder.Entity<TbAvaProjetosStatus>(entity =>
            {
                entity.HasKey(e => e.IdProjetoStatus);

                entity.ToTable("tbAvaProjetosStatus");

                entity.Property(e => e.IdProjetoStatus).HasColumnName("idProjetoStatus");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsParecer)
                    .HasMaxLength(1000)
                    .HasColumnName("dsParecer");

                entity.Property(e => e.DsStatus)
                    .HasMaxLength(50)
                    .HasColumnName("dsStatus");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.DtParecer)
                    .HasColumnType("date")
                    .HasColumnName("dtParecer");

                entity.Property(e => e.FlForceIn)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flForceIn")
                    .IsFixedLength();

                entity.Property(e => e.FlForceOut)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flForceOut")
                    .IsFixedLength();

                entity.Property(e => e.IdProjeto).HasColumnName("idProjeto");

                entity.HasOne(d => d.IdProjetoNavigation)
                    .WithMany(p => p.TbAvaProjetosStatuses)
                    .HasForeignKey(d => d.IdProjeto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbAvaProjetosStatus_tbPrjProjetos");
            });

            modelBuilder.Entity<TbMapObjetivo>(entity =>
            {
                entity.HasKey(e => e.IdObjetivo);

                entity.ToTable("tbMapObjetivos");

                entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjetivo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetivo");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.IdObjetivoMacro).HasColumnName("idObjetivoMacro");

                entity.HasOne(d => d.IdObjetivoMacroNavigation)
                    .WithMany(p => p.TbMapObjetivos)
                    .HasForeignKey(d => d.IdObjetivoMacro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMapObjetivos_tbMapObjetivosMacro");
            });

            modelBuilder.Entity<TbMapObjetivosGlobai>(entity =>
            {
                entity.HasKey(e => e.IdObjetivoGlobal);

                entity.ToTable("tbMapObjetivosGlobais");

                entity.Property(e => e.IdObjetivoGlobal).HasColumnName("idObjetivoGlobal");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjetivoGlobal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetivoGlobal");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.HasOne(d => d.IdVersaoNavigation)
                    .WithMany(p => p.TbMapObjetivosGlobais)
                    .HasForeignKey(d => d.IdVersao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMapObjetivosGlobais_tbMapVersao");
            });

            modelBuilder.Entity<TbMapObjetivosMacro>(entity =>
            {
                entity.HasKey(e => e.IdObjetivoMacro);

                entity.ToTable("tbMapObjetivosMacro");

                entity.Property(e => e.IdObjetivoMacro).HasColumnName("idObjetivoMacro");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjetivoMacro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetivoMacro");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.IdObjetivoGlobal).HasColumnName("idObjetivoGlobal");

                entity.HasOne(d => d.IdObjetivoGlobalNavigation)
                    .WithMany(p => p.TbMapObjetivosMacros)
                    .HasForeignKey(d => d.IdObjetivoGlobal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMapObjetivosMacro_tbMapObjetivosGlobais");
            });

            modelBuilder.Entity<TbMapObjetivosPlanejamento>(entity =>
            {
                entity.HasKey(e => new { e.IdObjetivo, e.IdAcao });

                entity.ToTable("tbMapObjetivosPlanejamento");

                entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");

                entity.Property(e => e.IdAcao).HasColumnName("idAcao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(10)
                    .HasColumnName("dsLogin")
                    .IsFixedLength();

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.HasOne(d => d.IdObjetivoNavigation)
                    .WithMany(p => p.TbMapObjetivosPlanejamentos)
                    .HasForeignKey(d => d.IdObjetivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMapObjetivosPlanejamento_tbMapObjetivos");
            });

            modelBuilder.Entity<TbMapVerso>(entity =>
            {
                entity.HasKey(e => e.IdVersao)
                    .HasName("PK_tbMapVersao");

                entity.ToTable("tbMapVersoes");

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsMissao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsMissao");

                entity.Property(e => e.DsStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsStatus");

                entity.Property(e => e.DsVisao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsVisao");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.NrAnoElaboracao).HasColumnName("nrAnoElaboracao");

                entity.Property(e => e.NrAnoFim).HasColumnName("nrAnoFim");

                entity.Property(e => e.NrAnoInicio).HasColumnName("nrAnoInicio");

                entity.Property(e => e.NrVersao).HasColumnName("nrVersao");
            });

            modelBuilder.Entity<TbMapVersoesValore>(entity =>
            {
                entity.HasKey(e => e.IdVersaoValores)
                    .HasName("PK_tbMapVersaoValores");

                entity.ToTable("tbMapVersoesValores");

                entity.Property(e => e.IdVersaoValores).HasColumnName("idVersaoValores");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsValor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsValor");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.HasOne(d => d.IdVersaoNavigation)
                    .WithMany(p => p.TbMapVersoesValores)
                    .HasForeignKey(d => d.IdVersao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbMapVersaoValores_tbMapVersao");
            });

            modelBuilder.Entity<TbPrjCriterio>(entity =>
            {
                entity.HasKey(e => e.IdCriterio);

                entity.ToTable("tbPrjCriterios");

                entity.Property(e => e.IdCriterio).HasColumnName("idCriterio");

                entity.Property(e => e.CdOrgaoResponsavel)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgaoResponsavel");

                entity.Property(e => e.CdUnidadeResposavel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidadeResposavel")
                    .IsFixedLength();

                entity.Property(e => e.DsCriterio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsCriterio");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCriterio).HasColumnName("nrCriterio");

                entity.HasOne(d => d.IdVersaoNavigation)
                    .WithMany(p => p.TbPrjCriterios)
                    .HasForeignKey(d => d.IdVersao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPrjCriterios_tbMapVersoes");
            });

            modelBuilder.Entity<TbPrjCriteriosPeso>(entity =>
            {
                entity.HasKey(e => e.IdCriterioPeso);

                entity.ToTable("tbPrjCriteriosPesos");

                entity.Property(e => e.IdCriterioPeso).HasColumnName("idCriterioPeso");

                entity.Property(e => e.CdOrgaoResponsavel)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgaoResponsavel");

                entity.Property(e => e.CdUnidadeResposavel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidadeResposavel")
                    .IsFixedLength();

                entity.Property(e => e.DsPeso)
                    .HasMaxLength(50)
                    .HasColumnName("dsPeso");

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrPeso).HasColumnName("nrPeso");
            });

            modelBuilder.Entity<TbPrjEscala>(entity =>
            {
                entity.HasKey(e => e.IdEscala)
                    .HasName("PK_tbPrjEscala_1");

                entity.ToTable("tbPrjEscala");

                entity.Property(e => e.IdEscala).HasColumnName("idEscala");

                entity.Property(e => e.CdOrgaoResponsavel)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgaoResponsavel");

                entity.Property(e => e.CdUnidadeResposavel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidadeResposavel")
                    .IsFixedLength();

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.VlReciproco)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("vlReciproco");

                entity.Property(e => e.VlValor)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("vlValor");

                entity.HasOne(d => d.IdEscalaItemNavigation)
                    .WithMany(p => p.TbPrjEscalas)
                    .HasForeignKey(d => d.IdEscalaItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPrjEscala_tbPrjEscalaItens");

                entity.HasOne(d => d.IdVersaoNavigation)
                    .WithMany(p => p.TbPrjEscalas)
                    .HasForeignKey(d => d.IdVersao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPrjEscala_tbMapVersoes");
            });

            modelBuilder.Entity<TbPrjEscalaCriterio>(entity =>
            {
                entity.HasKey(e => e.IdEscalaCriterio);

                entity.ToTable("tbPrjEscalaCriterio");

                entity.Property(e => e.IdEscalaCriterio).HasColumnName("idEscalaCriterio");

                entity.Property(e => e.IdCriterioColuna).HasColumnName("idCriterioColuna");

                entity.Property(e => e.IdCriterioLinha).HasColumnName("idCriterioLinha");

                entity.Property(e => e.IdEscala).HasColumnName("idEscala");

                entity.Property(e => e.VlValor)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("vlValor");

                entity.HasOne(d => d.IdCriterioColunaNavigation)
                    .WithMany(p => p.TbPrjEscalaCriterioIdCriterioColunaNavigations)
                    .HasForeignKey(d => d.IdCriterioColuna)
                    .HasConstraintName("FK_tbPrjEscalaCriterio_tbPrjCriterios2");

                entity.HasOne(d => d.IdCriterioLinhaNavigation)
                    .WithMany(p => p.TbPrjEscalaCriterioIdCriterioLinhaNavigations)
                    .HasForeignKey(d => d.IdCriterioLinha)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPrjEscalaCriterio_tbPrjCriterios1");
            });

            modelBuilder.Entity<TbPrjEscalaIten>(entity =>
            {
                entity.HasKey(e => e.IdEscalaItem);

                entity.ToTable("tbPrjEscalaItens");

                entity.Property(e => e.IdEscalaItem).HasColumnName("idEscalaItem");

                entity.Property(e => e.DsItem)
                    .HasMaxLength(50)
                    .HasColumnName("dsItem");
            });

            modelBuilder.Entity<TbPrjProjeto>(entity =>
            {
                entity.HasKey(e => e.IdProjeto)
                    .HasName("PK_tbPrjProposta");

                entity.ToTable("tbPrjProjetos");

                entity.Property(e => e.IdProjeto).HasColumnName("idProjeto");

                entity.Property(e => e.CdOrgaoResponsavel)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgaoResponsavel");

                entity.Property(e => e.CdProjeto).HasColumnName("cdProjeto");

                entity.Property(e => e.CdUnidadeResposavel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidadeResposavel")
                    .IsFixedLength();

                entity.Property(e => e.DsEscopo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsEscopo");

                entity.Property(e => e.DsFase)
                    .HasMaxLength(10)
                    .HasColumnName("dsFase");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsMetas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsMetas");

                entity.Property(e => e.DsTaxaInternaRetorno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTaxaInternaRetorno");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.DtFim)
                    .HasColumnType("date")
                    .HasColumnName("dtFim");

                entity.Property(e => e.DtInicio)
                    .HasColumnType("date")
                    .HasColumnName("dtInicio");

                entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.Property(e => e.NmProjeto)
                    .HasMaxLength(100)
                    .HasColumnName("nmProjeto");

                entity.Property(e => e.NrAnoElaboracao).HasColumnName("nrAnoElaboracao");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("vlOrcado");

                entity.HasOne(d => d.IdObjetivoNavigation)
                    .WithMany(p => p.TbPrjProjetos)
                    .HasForeignKey(d => d.IdObjetivo)
                    .HasConstraintName("FK_tbPrjProposta_tbMapObjetivos");

                entity.HasOne(d => d.IdVersaoNavigation)
                    .WithMany(p => p.TbPrjProjetos)
                    .HasForeignKey(d => d.IdVersao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPrjProjetos_tbMapVersoes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
