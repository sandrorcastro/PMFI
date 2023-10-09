﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MegaDataDBContext))]
    [Migration("20230905201825_AumentaNomeLogradouro")]
    partial class AumentaNomeLogradouro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Cidade", b =>
                {
                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("id_cidade");

                    b.Property<int?>("CodigoIbge")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ibge");

                    b.Property<int?>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("id_pais");

                    b.Property<int?>("IdUf")
                        .HasColumnType("int")
                        .HasColumnName("id_uf");

                    b.Property<decimal?>("Latitude")
                        .HasColumnType("numeric(9,6)")
                        .HasColumnName("latitude");

                    b.Property<decimal?>("Longitude")
                        .HasColumnType("numeric(9,6)")
                        .HasColumnName("longitude");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("SinCapital")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("sin_capital")
                        .IsFixedLength();

                    b.HasKey("IdCidade")
                        .HasName("pk_cidade");

                    b.HasIndex(new[] { "IdUf", "Nome" }, "ak1_cidade")
                        .IsUnique()
                        .HasFilter("[id_uf] IS NOT NULL");

                    b.HasIndex(new[] { "IdPais" }, "fk_cidade_pais");

                    b.HasIndex(new[] { "IdUf" }, "fk_cidade_uf");

                    b.HasIndex(new[] { "IdPais", "IdUf", "SinCapital", "CodigoIbge" }, "i01_cidade");

                    b.ToTable("cidade", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Logradouro", b =>
                {
                    b.Property<int>("IdLogradouro")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoLogradouro")
                        .HasColumnType("int");

                    b.Property<string>("LogradTipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeLogradouro")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("IdLogradouro");

                    b.HasIndex("IdTipoLogradouro");

                    b.ToTable("Logradouro", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("id_pais");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("IdPais")
                        .HasName("pk_pais");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoLogradouro", b =>
                {
                    b.Property<int>("IdTipoLogadouro")
                        .HasColumnType("int");

                    b.Property<string>("Dstipologradouro")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTipoLogadouro");

                    b.ToTable("TipoLogradouro", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Uf", b =>
                {
                    b.Property<int>("IdUf")
                        .HasColumnType("int")
                        .HasColumnName("id_uf");

                    b.Property<int?>("CodigoIbge")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ibge");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("id_pais");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Sigla")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("sigla")
                        .IsFixedLength();

                    b.HasKey("IdUf")
                        .HasName("pk_uf");

                    b.HasIndex(new[] { "IdPais" }, "fk_uf_pais");

                    b.ToTable("uf", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cidade", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisNavigation")
                        .WithMany("Cidades")
                        .HasForeignKey("IdPais")
                        .HasConstraintName("fk_cidade_pais");

                    b.HasOne("Domain.Entities.Uf", "IdUfNavigation")
                        .WithMany("Cidades")
                        .HasForeignKey("IdUf")
                        .HasConstraintName("fk_cidade_uf");

                    b.Navigation("IdPaisNavigation");

                    b.Navigation("IdUfNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Logradouro", b =>
                {
                    b.HasOne("Domain.Entities.TipoLogradouro", "TipoLogradouro")
                        .WithMany("Logradouros")
                        .HasForeignKey("IdTipoLogradouro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoLogradouro");
                });

            modelBuilder.Entity("Domain.Entities.Uf", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisNavigation")
                        .WithMany("Ufs")
                        .HasForeignKey("IdPais")
                        .IsRequired()
                        .HasConstraintName("fk_uf_pais");

                    b.Navigation("IdPaisNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Cidades");

                    b.Navigation("Ufs");
                });

            modelBuilder.Entity("Domain.Entities.TipoLogradouro", b =>
                {
                    b.Navigation("Logradouros");
                });

            modelBuilder.Entity("Domain.Entities.Uf", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}