using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GerarClasses.Entities
{
    public partial class SEIContext : DbContext
    {
        public SEIContext()
        {
        }

        public SEIContext(DbContextOptions<SEIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cidade> Cidades { get; set; } = null!;
        public virtual DbSet<Pais> Pais { get; set; } = null!;
        public virtual DbSet<Uf> Ufs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=SEI;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=rpdesenv;Password=visual");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.IdCidade)
                    .HasName("pk_cidade");

                entity.ToTable("cidade");

                entity.HasIndex(e => new { e.IdUf, e.Nome }, "ak1_cidade")
                    .IsUnique();

                entity.HasIndex(e => e.IdPais, "fk_cidade_pais");

                entity.HasIndex(e => e.IdUf, "fk_cidade_uf");

                entity.HasIndex(e => new { e.IdPais, e.IdUf, e.SinCapital, e.CodigoIbge }, "i01_cidade");

                entity.Property(e => e.IdCidade)
                    .ValueGeneratedNever()
                    .HasColumnName("id_cidade");

                entity.Property(e => e.CodigoIbge).HasColumnName("codigo_ibge");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.IdUf).HasColumnName("id_uf");

                entity.Property(e => e.Latitude)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasColumnType("numeric(9, 6)")
                    .HasColumnName("longitude");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.SinCapital)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sin_capital")
                    .IsFixedLength();

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("fk_cidade_pais");

                entity.HasOne(d => d.IdUfNavigation)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.IdUf)
                    .HasConstraintName("fk_cidade_uf");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("pk_pais");

                entity.ToTable("pais");

                entity.Property(e => e.IdPais)
                    .ValueGeneratedNever()
                    .HasColumnName("id_pais");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Uf>(entity =>
            {
                entity.HasKey(e => e.IdUf)
                    .HasName("pk_uf");

                entity.ToTable("uf");

                entity.HasIndex(e => e.IdPais, "fk_uf_pais");

                entity.Property(e => e.IdUf)
                    .ValueGeneratedNever()
                    .HasColumnName("id_uf");

                entity.Property(e => e.CodigoIbge).HasColumnName("codigo_ibge");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sigla")
                    .IsFixedLength();

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Ufs)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_uf_pais");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
