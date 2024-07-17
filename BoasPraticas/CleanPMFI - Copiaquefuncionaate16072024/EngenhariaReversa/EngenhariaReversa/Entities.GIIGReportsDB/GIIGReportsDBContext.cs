using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class GIIGReportsDBContext : DbContext
    {
        public GIIGReportsDBContext()
        {
        }

        public GIIGReportsDBContext(DbContextOptions<GIIGReportsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbBancosDado> TbBancosDados { get; set; } = null!;
        public virtual DbSet<TbColuna> TbColunas { get; set; } = null!;
        public virtual DbSet<TbLogScriptExecutado> TbLogScriptExecutados { get; set; } = null!;
        public virtual DbSet<TbMenu> TbMenus { get; set; } = null!;
        public virtual DbSet<TbPermisso> TbPermissoes { get; set; } = null!;
        public virtual DbSet<TbRelatorio> TbRelatorios { get; set; } = null!;
        public virtual DbSet<TbRelatoriosColuna> TbRelatoriosColunas { get; set; } = null!;
        public virtual DbSet<TbRelatoriosTabela> TbRelatoriosTabelas { get; set; } = null!;
        public virtual DbSet<TbTabela> TbTabelas { get; set; } = null!;
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGReportsDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<TbBancosDado>(entity =>
            {
                entity.HasKey(e => e.IdBancoDados);

                entity.ToTable("tbBancosDados");

                entity.Property(e => e.DsConnectionString)
                    .IsUnicode(false)
                    .HasColumnName("dsConnectionString");

                entity.Property(e => e.DsSenha)
                    .IsUnicode(false)
                    .HasColumnName("dsSenha");

                entity.Property(e => e.DsServidor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsServidor");

                entity.Property(e => e.DsUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsUsuario");

                entity.Property(e => e.NmAmigavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmAmigavel");

                entity.Property(e => e.NmBancoDados)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmBancoDados");

                entity.Property(e => e.TpBancoDados)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tpBancoDados");
            });

            modelBuilder.Entity<TbColuna>(entity =>
            {
                entity.HasKey(e => e.IdColuna);

                entity.ToTable("tbColunas");

                entity.Property(e => e.DbColumId).HasColumnName("dbColumId");

                entity.Property(e => e.FlChaveEstrangeira).HasColumnName("flChaveEstrangeira");

                entity.Property(e => e.FlChavePrimaria).HasColumnName("flChavePrimaria");

                entity.Property(e => e.IsChecked).HasDefaultValueSql("((0))");

                entity.Property(e => e.NmAmigavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmAmigavel");

                entity.Property(e => e.NmColuna)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmColuna");

                entity.Property(e => e.NrDecimais).HasColumnName("nrDecimais");

                entity.Property(e => e.NrObjectId).HasColumnName("nrObjectId");

                entity.Property(e => e.NrTamanho).HasColumnName("nrTamanho");

                entity.HasOne(d => d.IdTabelaNavigation)
                    .WithMany(p => p.TbColunas)
                    .HasForeignKey(d => d.IdTabela)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbColunas_tbTabelas");
            });

            modelBuilder.Entity<TbLogScriptExecutado>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tbLogScriptExecutado");

                entity.Property(e => e.DsIp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsIP");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsLoginDba)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginDBA");

                entity.Property(e => e.DsSql)
                    .IsUnicode(false)
                    .HasColumnName("dsSQL");

                entity.Property(e => e.DtLog)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLog");

                entity.Property(e => e.NmBaseDados)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmBaseDados");
            });

            modelBuilder.Entity<TbMenu>(entity =>
            {
                entity.HasKey(e => e.DsLogin);

                entity.ToTable("tbMenus");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.FlConfiguracoes).HasColumnName("flConfiguracoes");

                entity.Property(e => e.FlConsulta).HasColumnName("flConsulta");

                entity.Property(e => e.FlUsuarios).HasColumnName("flUsuarios");
            });

            modelBuilder.Entity<TbPermisso>(entity =>
            {
                entity.HasKey(e => new { e.DsLogin, e.IdBancoDados });

                entity.ToTable("tbPermissoes");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.HasOne(d => d.IdBancoDadosNavigation)
                    .WithMany(p => p.TbPermissos)
                    .HasForeignKey(d => d.IdBancoDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPermissoes_tbBancosDados");
            });

            modelBuilder.Entity<TbRelatorio>(entity =>
            {
                entity.HasKey(e => e.IdRelatorio);

                entity.ToTable("tbRelatorios");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.NmRelatorio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRelatorio");
            });

            modelBuilder.Entity<TbRelatoriosColuna>(entity =>
            {
                entity.HasKey(e => new { e.IdRelatorio, e.IdColuna });

                entity.ToTable("tbRelatoriosColunas");

                entity.Property(e => e.DsAgrupador)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("dsAgrupador");

                entity.Property(e => e.DsCondicao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("dsCondicao");

                entity.Property(e => e.DsFiltro)
                    .IsUnicode(false)
                    .HasColumnName("dsFiltro");

                entity.Property(e => e.DsOperador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsOperador");

                entity.Property(e => e.FlAgrupar).HasColumnName("flAgrupar");

                entity.HasOne(d => d.IdColunaNavigation)
                    .WithMany(p => p.TbRelatoriosColunas)
                    .HasForeignKey(d => d.IdColuna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbRelatoriosColunas_tbColunas");

                entity.HasOne(d => d.IdRelatorioNavigation)
                    .WithMany(p => p.TbRelatoriosColunas)
                    .HasForeignKey(d => d.IdRelatorio)
                    .HasConstraintName("FK_tbRelatoriosColunas_tbRelatorios");
            });

            modelBuilder.Entity<TbRelatoriosTabela>(entity =>
            {
                entity.HasKey(e => new { e.IdRelatorio, e.IdTabela });

                entity.ToTable("tbRelatoriosTabelas");

                entity.Property(e => e.FlPrincipal).HasColumnName("flPrincipal");

                entity.HasOne(d => d.IdRelatorioNavigation)
                    .WithMany(p => p.TbRelatoriosTabelas)
                    .HasForeignKey(d => d.IdRelatorio)
                    .HasConstraintName("FK_tbRelatoriosTabelas_tbRelatorios");

                entity.HasOne(d => d.IdTabelaNavigation)
                    .WithMany(p => p.TbRelatoriosTabelas)
                    .HasForeignKey(d => d.IdTabela)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbRelatoriosTabelas_tbTabelas");
            });

            modelBuilder.Entity<TbTabela>(entity =>
            {
                entity.HasKey(e => e.IdTabela);

                entity.ToTable("tbTabelas");

                entity.Property(e => e.DsAjuda)
                    .IsUnicode(false)
                    .HasColumnName("dsAjuda");

                entity.Property(e => e.FlPrincipal).HasColumnName("flPrincipal");

                entity.Property(e => e.NmAmigavel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmAmigavel");

                entity.Property(e => e.NmTabelaBanco)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nmTabelaBanco");

                entity.Property(e => e.NrObjectId).HasColumnName("nrObjectId");

                entity.HasOne(d => d.IdBancoDadosNavigation)
                    .WithMany(p => p.TbTabelas)
                    .HasForeignKey(d => d.IdBancoDados)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbTabelas_tbBancosDados");
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.DsLogin);

                entity.ToTable("tbUsuarios");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsEmail");

                entity.Property(e => e.DsSenha)
                    .HasMaxLength(50)
                    .HasColumnName("dsSenha");

                entity.Property(e => e.FlAtivo).HasColumnName("flAtivo");

                entity.Property(e => e.FlDba).HasColumnName("flDBA");

                entity.Property(e => e.NmUsuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmUsuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
