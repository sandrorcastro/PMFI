﻿// <auto-generated />
using System;
using MVC.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.Migrations
{
    [DbContext(typeof(ContextoAplicacao))]
    [Migration("20230523161424_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EconomiaEndereco", b =>
                {
                    b.Property<long>("EnderecosEnderecoId")
                        .HasColumnType("bigint");

                    b.Property<long>("EconomiasImovelId")
                        .HasColumnType("bigint");

                    b.Property<long>("EconomiasEconomiaId")
                        .HasColumnType("bigint");

                    b.HasKey("EnderecosEnderecoId", "EconomiasImovelId", "EconomiasEconomiaId");

                    b.HasIndex("EconomiasImovelId", "EconomiasEconomiaId");

                    b.ToTable("EconomiaEndereco");
                });

            modelBuilder.Entity("EconomiaPessoa", b =>
                {
                    b.Property<long>("PessoasPessoaId")
                        .HasColumnType("bigint");

                    b.Property<long>("EconomiasImovelId")
                        .HasColumnType("bigint");

                    b.Property<long>("EconomiasEconomiaId")
                        .HasColumnType("bigint");

                    b.HasKey("PessoasPessoaId", "EconomiasImovelId", "EconomiasEconomiaId");

                    b.HasIndex("EconomiasImovelId", "EconomiasEconomiaId");

                    b.ToTable("EconomiaPessoa");
                });

            modelBuilder.Entity("EnderecoImovel", b =>
                {
                    b.Property<long>("EnderecosEnderecoId")
                        .HasColumnType("bigint");

                    b.Property<long>("ImoveisImovelId")
                        .HasColumnType("bigint");

                    b.HasKey("EnderecosEnderecoId", "ImoveisImovelId");

                    b.HasIndex("ImoveisImovelId");

                    b.ToTable("EnderecoImovel");
                });

            modelBuilder.Entity("EnderecoPessoa", b =>
                {
                    b.Property<long>("EnderecosEnderecoId")
                        .HasColumnType("bigint");

                    b.Property<long>("PessoasPessoaId")
                        .HasColumnType("bigint");

                    b.HasKey("EnderecosEnderecoId", "PessoasPessoaId");

                    b.HasIndex("PessoasPessoaId");

                    b.ToTable("EnderecoPessoa");
                });

            modelBuilder.Entity("MVC.Models.Economia", b =>
                {
                    b.Property<long>("ImovelId")
                        .HasColumnType("bigint");

                    b.Property<long>("EconomiaId")
                        .HasColumnType("bigint");

                    b.HasKey("ImovelId", "EconomiaId");

                    b.ToTable("Economia", (string)null);
                });

            modelBuilder.Entity("MVC.Models.Economia_Entidade", b =>
                {
                    b.Property<long?>("ImovelId")
                        .HasColumnType("bigint");

                    b.Property<long?>("EconomiaId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PessoaId")
                        .HasColumnType("bigint");

                    b.HasKey("ImovelId", "EconomiaId", "PessoaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Economia_Entidade", (string)null);
                });

            modelBuilder.Entity("MVC.Models.Endereco", b =>
                {
                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco", (string)null);
                });

            modelBuilder.Entity("MVC.Models.Endereco_Entidade", b =>
                {
                    b.Property<long>("EntidadeId")
                        .HasColumnType("bigint");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<int?>("TipoEntidadeId")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<long?>("EconomiaId")
                        .HasColumnType("bigint");

                    b.Property<long?>("EconomiaImovelId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ImovelId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PessoaId")
                        .HasColumnType("bigint");

                    b.HasKey("EntidadeId", "EnderecoId", "TipoEntidadeId", "Numero");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("ImovelId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("EconomiaImovelId", "EconomiaId");

                    b.ToTable("Endereco_Entidade", (string)null);
                });

            modelBuilder.Entity("MVC.Models.Imovel", b =>
                {
                    b.Property<long>("ImovelId")
                        .HasColumnType("bigint");

                    b.HasKey("ImovelId");

                    b.ToTable("Imovel", (string)null);
                });

            modelBuilder.Entity("MVC.Models.Pessoa", b =>
                {
                    b.Property<long>("PessoaId")
                        .HasColumnType("bigint");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EconomiaEndereco", b =>
                {
                    b.HasOne("MVC.Models.Endereco", null)
                        .WithMany()
                        .HasForeignKey("EnderecosEnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Economia", null)
                        .WithMany()
                        .HasForeignKey("EconomiasImovelId", "EconomiasEconomiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EconomiaPessoa", b =>
                {
                    b.HasOne("MVC.Models.Pessoa", null)
                        .WithMany()
                        .HasForeignKey("PessoasPessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Economia", null)
                        .WithMany()
                        .HasForeignKey("EconomiasImovelId", "EconomiasEconomiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnderecoImovel", b =>
                {
                    b.HasOne("MVC.Models.Endereco", null)
                        .WithMany()
                        .HasForeignKey("EnderecosEnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Imovel", null)
                        .WithMany()
                        .HasForeignKey("ImoveisImovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnderecoPessoa", b =>
                {
                    b.HasOne("MVC.Models.Endereco", null)
                        .WithMany()
                        .HasForeignKey("EnderecosEnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Pessoa", null)
                        .WithMany()
                        .HasForeignKey("PessoasPessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC.Models.Economia", b =>
                {
                    b.HasOne("MVC.Models.Imovel", "Imovel")
                        .WithMany("Economias")
                        .HasForeignKey("ImovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imovel");
                });

            modelBuilder.Entity("MVC.Models.Economia_Entidade", b =>
                {
                    b.HasOne("MVC.Models.Imovel", "Imovel")
                        .WithMany("Economia_Entidades")
                        .HasForeignKey("ImovelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MVC.Models.Pessoa", "Pessoa")
                        .WithMany("Economia_Entidades")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MVC.Models.Economia", "Economia")
                        .WithMany("Economia_Pessoas")
                        .HasForeignKey("ImovelId", "EconomiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Economia");

                    b.Navigation("Imovel");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("MVC.Models.Endereco_Entidade", b =>
                {
                    b.HasOne("MVC.Models.Endereco", "Endereco")
                        .WithMany("Endereco_Entidades")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Imovel", "Imovel")
                        .WithMany("Endereco_Entidades")
                        .HasForeignKey("ImovelId");

                    b.HasOne("MVC.Models.Pessoa", "Pessoa")
                        .WithMany("Endereco_Entidades")
                        .HasForeignKey("PessoaId");

                    b.HasOne("MVC.Models.Economia", "Economia")
                        .WithMany("Endereco_Entidades")
                        .HasForeignKey("EconomiaImovelId", "EconomiaId");

                    b.Navigation("Economia");

                    b.Navigation("Endereco");

                    b.Navigation("Imovel");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC.Models.Economia", b =>
                {
                    b.Navigation("Economia_Pessoas");

                    b.Navigation("Endereco_Entidades");
                });

            modelBuilder.Entity("MVC.Models.Endereco", b =>
                {
                    b.Navigation("Endereco_Entidades");
                });

            modelBuilder.Entity("MVC.Models.Imovel", b =>
                {
                    b.Navigation("Economia_Entidades");

                    b.Navigation("Economias");

                    b.Navigation("Endereco_Entidades");
                });

            modelBuilder.Entity("MVC.Models.Pessoa", b =>
                {
                    b.Navigation("Economia_Entidades");

                    b.Navigation("Endereco_Entidades");
                });
#pragma warning restore 612, 618
        }
    }
}