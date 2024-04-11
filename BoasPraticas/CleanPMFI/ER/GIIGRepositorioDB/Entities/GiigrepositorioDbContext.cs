using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GIIGRepositorioDB.Entities;

public partial class GiigrepositorioDbContext : DbContext
{
    public GiigrepositorioDbContext()
    {
    }

    public GiigrepositorioDbContext(DbContextOptions<GiigrepositorioDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbRepArq00000001> TbRepArq00000001s { get; set; }

    public virtual DbSet<TbRepArq00000002> TbRepArq00000002s { get; set; }

    public virtual DbSet<TbRepArquivo> TbRepArquivos { get; set; }

    public virtual DbSet<TbRepDadosArquivo> TbRepDadosArquivos { get; set; }

    public virtual DbSet<TbRepRepositorio> TbRepRepositorios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGRepositorioDB;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=gilberto.gc;Password=Couto2408@@");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<TbRepArq00000001>(entity =>
        {
            entity.HasKey(e => e.IdArquivo).HasName("PK__tbRepArq__C91FC4C20AD2A005");

            entity.ToTable("tbRepArq00000001");

            entity.Property(e => e.IdArquivo)
                .ValueGeneratedNever()
                .HasColumnName("idArquivo");
            entity.Property(e => e.BnArquivo).HasColumnName("bnArquivo");
            entity.Property(e => e.DsExtensao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dsExtensao");
            entity.Property(e => e.NmArquivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nmArquivo");
        });

        modelBuilder.Entity<TbRepArq00000002>(entity =>
        {
            entity.HasKey(e => e.IdArquivo).HasName("PK__tbRepArq__C91FC4C20EA330E9");

            entity.ToTable("tbRepArq00000002");

            entity.Property(e => e.IdArquivo)
                .ValueGeneratedNever()
                .HasColumnName("idArquivo");
            entity.Property(e => e.BnArquivo).HasColumnName("bnArquivo");
            entity.Property(e => e.DsExtensao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dsExtensao");
            entity.Property(e => e.NmArquivo)
                .IsUnicode(false)
                .HasColumnName("nmArquivo");
        });

        modelBuilder.Entity<TbRepArquivo>(entity =>
        {
            entity.HasKey(e => e.IdArquivo).HasName("PK_tbDocDocumento");

            entity.ToTable("tbRepArquivo");

            entity.Property(e => e.IdArquivo)
                .ValueGeneratedNever()
                .HasColumnName("idArquivo");
            entity.Property(e => e.BnArquivo).HasColumnName("bnArquivo");
            entity.Property(e => e.DsExtensao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dsExtensao");
            entity.Property(e => e.NmArquivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nmArquivo");
        });

        modelBuilder.Entity<TbRepDadosArquivo>(entity =>
        {
            entity.HasKey(e => e.IdReferencia).HasName("PK_tbDocReferencia");

            entity.ToTable("tbRepDadosArquivo");

            entity.Property(e => e.IdReferencia)
                .ValueGeneratedNever()
                .HasColumnName("idReferencia");
            entity.Property(e => e.DsExclusao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dsExclusao");
            entity.Property(e => e.DsPalavraChave)
                .IsUnicode(false)
                .HasColumnName("dsPalavraChave");
            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dtInclusao");
            entity.Property(e => e.FlExcluido)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flExcluido");
            entity.Property(e => e.IdArquivo).HasColumnName("idArquivo");
            entity.Property(e => e.IdRepositorio).HasColumnName("idRepositorio");
            entity.Property(e => e.NmUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nmUsuario");
            entity.Property(e => e.NrReferencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrReferencia");

            entity.HasOne(d => d.IdRepositorioNavigation).WithMany(p => p.TbRepDadosArquivos)
                .HasForeignKey(d => d.IdRepositorio)
                .HasConstraintName("FK_tbRepDadosArquivo_tbRepRepositorio");
        });

        modelBuilder.Entity<TbRepRepositorio>(entity =>
        {
            entity.HasKey(e => e.IdRepositorio).HasName("PK_tbDocAcesso");

            entity.ToTable("tbRepRepositorio");

            entity.Property(e => e.IdRepositorio)
                .ValueGeneratedNever()
                .HasColumnName("idRepositorio");
            entity.Property(e => e.DsRepositorio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dsRepositorio");
            entity.Property(e => e.NmRepositorio)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nmRepositorio");
            entity.Property(e => e.NrChave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrChave");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
