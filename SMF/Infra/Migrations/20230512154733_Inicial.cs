﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar", nullable: true),
                    SecurityStamp = table.Column<string>(type: "varchar", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dbSPaises",
                columns: table => new
                {
                    PaisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar", nullable: true),
                    Sigla = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSPaises", x => x.PaisId);
                });

            migrationBuilder.CreateTable(
                name: "dbSTiposLogradouro",
                columns: table => new
                {
                    TipoLogradouroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSTiposLogradouro", x => x.TipoLogradouroId);
                });

            migrationBuilder.CreateTable(
                name: "DDD",
                columns: table => new
                {
                    DDDId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoDDD = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDD", x => x.DDDId);
                });

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    ImovelId = table.Column<long>(type: "bigint", nullable: false),
                    Matricula = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Latitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Longitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Complemento = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    AreaTerreno = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    AreaConstruida = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    AnoConstrucao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Caracteristica = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.ImovelId);
                });

            migrationBuilder.CreateTable(
                name: "IncrementoTabelas",
                columns: table => new
                {
                    IncrementoTabelasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tabela = table.Column<string>(type: "varchar", nullable: true),
                    Parametro = table.Column<string>(type: "varchar", nullable: true),
                    valorAtual = table.Column<long>(type: "bigint", nullable: true),
                    Ano = table.Column<string>(type: "varchar", nullable: true),
                    valorInicial = table.Column<long>(type: "bigint", nullable: true),
                    valorFinal = table.Column<long>(type: "bigint", nullable: true),
                    valorincrementar = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncrementoTabelas", x => x.IncrementoTabelasId);
                });

            migrationBuilder.CreateTable(
                name: "OperadoraTelefone",
                columns: table => new
                {
                    OperadoraTelefoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true),
                    CodigoOperadora = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperadoraTelefone", x => x.OperadoraTelefoneId);
                });

            migrationBuilder.CreateTable(
                name: "Orgao",
                columns: table => new
                {
                    OrgaoId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orgao", x => x.OrgaoId);
                });

            migrationBuilder.CreateTable(
                name: "Perspectiva",
                columns: table => new
                {
                    PerspectivaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perspectiva", x => x.PerspectivaId);
                });

            migrationBuilder.CreateTable(
                name: "Servidor",
                columns: table => new
                {
                    ServidorId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Matricula = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidor", x => x.ServidorId);
                });

            migrationBuilder.CreateTable(
                name: "SituacaoEtapa",
                columns: table => new
                {
                    SituacaoEtapaId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoEtapa", x => x.SituacaoEtapaId);
                });

            migrationBuilder.CreateTable(
                name: "SituacaoProcesso",
                columns: table => new
                {
                    SituacaoProcessoId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoProcesso", x => x.SituacaoProcessoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoContato",
                columns: table => new
                {
                    TipoContatoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContato", x => x.TipoContatoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.TipoDocumentoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoEtapa",
                columns: table => new
                {
                    TipoEtapaId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    DiasTramite = table.Column<int>(type: "int", nullable: true),
                    Permanencia = table.Column<int>(type: "int", nullable: true),
                    Lei = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    TextoLei = table.Column<string>(type: "varchar", nullable: true),
                    Template = table.Column<string>(type: "varchar", nullable: true),
                    liberado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEtapa", x => x.TipoEtapaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoPessoa",
                columns: table => new
                {
                    TipoPessoaId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPessoa", x => x.TipoPessoaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoProcesso",
                columns: table => new
                {
                    TipoProcessoId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    DiasTramite = table.Column<int>(type: "int", nullable: true),
                    Permanencia = table.Column<int>(type: "int", nullable: true),
                    liberado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProcesso", x => x.TipoProcessoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoResponsabilidade",
                columns: table => new
                {
                    TipoResponsabilidadeId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoResponsabilidade", x => x.TipoResponsabilidadeId);
                });

            migrationBuilder.CreateTable(
                name: "TipoTelefone",
                columns: table => new
                {
                    TipoTelefoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTelefone", x => x.TipoTelefoneId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar", nullable: true),
                    ClaimValue = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar", nullable: true),
                    ClaimValue = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "varchar", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbSEstados",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true),
                    Sigla = table.Column<string>(type: "varchar", nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSEstados", x => x.EstadoId);
                    table.ForeignKey(
                        name: "FK_dbSEstados_dbSPaises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "dbSPaises",
                        principalColumn: "PaisId");
                });

            migrationBuilder.CreateTable(
                name: "Economia",
                columns: table => new
                {
                    ImovelId = table.Column<long>(type: "bigint", nullable: false),
                    EconomiaId = table.Column<long>(type: "bigint", nullable: false),
                    Latitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Longitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Complemento = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    AreaConstruida = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    AnoConstrucao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Numeracao = table.Column<string>(type: "varchar", nullable: true),
                    Caracteristica = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Matricula = table.Column<string>(type: "varchar", nullable: true),
                    TemProcessos = table.Column<bool>(type: "bit", nullable: true),
                    TerrenoIdTemp = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economia", x => new { x.ImovelId, x.EconomiaId });
                    table.ForeignKey(
                        name: "FK_Economia_Imovel_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imovel",
                        principalColumn: "ImovelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    OrgaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.UnidadeId);
                    table.ForeignKey(
                        name: "FK_Unidade_Orgao_OrgaoId",
                        column: x => x.OrgaoId,
                        principalTable: "Orgao",
                        principalColumn: "OrgaoId");
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    TipoPessoaId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    conId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Pessoa_TipoPessoa_TipoPessoaId",
                        column: x => x.TipoPessoaId,
                        principalTable: "TipoPessoa",
                        principalColumn: "TipoPessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FluxoProcesso",
                columns: table => new
                {
                    FluxoProcessoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: false),
                    TipoProcessoId = table.Column<int>(type: "int", nullable: false),
                    TipoEtapaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluxoProcesso", x => x.FluxoProcessoId);
                    table.ForeignKey(
                        name: "FK_FluxoProcesso_TipoEtapa_TipoEtapaId",
                        column: x => x.TipoEtapaId,
                        principalTable: "TipoEtapa",
                        principalColumn: "TipoEtapaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluxoProcesso_TipoProcesso_TipoProcessoId",
                        column: x => x.TipoProcessoId,
                        principalTable: "TipoProcesso",
                        principalColumn: "TipoProcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    ContatoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoContatoId = table.Column<int>(type: "int", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Principal = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "varchar", nullable: false),
                    TipoTelefoneId = table.Column<int>(type: "int", nullable: true),
                    DDDId = table.Column<int>(type: "int", nullable: true),
                    OperadoraTelefoneId = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Numero = table.Column<string>(type: "varchar", nullable: true),
                    TelefoneResidencial_Numero = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.ContatoId);
                    table.ForeignKey(
                        name: "FK_Contato_DDD_DDDId",
                        column: x => x.DDDId,
                        principalTable: "DDD",
                        principalColumn: "DDDId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_OperadoraTelefone_OperadoraTelefoneId",
                        column: x => x.OperadoraTelefoneId,
                        principalTable: "OperadoraTelefone",
                        principalColumn: "OperadoraTelefoneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_TipoContato_TipoContatoId",
                        column: x => x.TipoContatoId,
                        principalTable: "TipoContato",
                        principalColumn: "TipoContatoId");
                    table.ForeignKey(
                        name: "FK_Contato_TipoTelefone_TipoTelefoneId",
                        column: x => x.TipoTelefoneId,
                        principalTable: "TipoTelefone",
                        principalColumn: "TipoTelefoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbSCidades",
                columns: table => new
                {
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: true),
                    DDDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSCidades", x => x.CidadeId);
                    table.ForeignKey(
                        name: "FK_dbSCidades_DDD_DDDId",
                        column: x => x.DDDId,
                        principalTable: "DDD",
                        principalColumn: "DDDId");
                    table.ForeignKey(
                        name: "FK_dbSCidades_dbSEstados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "dbSEstados",
                        principalColumn: "EstadoId");
                });

            migrationBuilder.CreateTable(
                name: "DocumentoPessoa",
                columns: table => new
                {
                    DocumentoPessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "varchar", nullable: true),
                    Discriminator = table.Column<string>(type: "varchar", nullable: false),
                    CNPJ_DataExpedicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CNPJ_EstadoEmissorId = table.Column<int>(type: "int", nullable: true),
                    CNPJ_OrgaoEmissor = table.Column<string>(type: "varchar", nullable: true),
                    DataExpedicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoEmissorId = table.Column<int>(type: "int", nullable: true),
                    OrgaoEmissor = table.Column<string>(type: "varchar", nullable: true),
                    RG_DataExpedicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RG_EstadoEmissorId = table.Column<int>(type: "int", nullable: true),
                    RG_OrgaoEmissor = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoPessoa", x => x.DocumentoPessoaId);
                    table.ForeignKey(
                        name: "FK_DocumentoPessoa_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentoPessoa_TipoDocumento_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumento",
                        principalColumn: "TipoDocumentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentoPessoa_dbSEstados_CNPJ_EstadoEmissorId",
                        column: x => x.CNPJ_EstadoEmissorId,
                        principalTable: "dbSEstados",
                        principalColumn: "EstadoId");
                    table.ForeignKey(
                        name: "FK_DocumentoPessoa_dbSEstados_EstadoEmissorId",
                        column: x => x.EstadoEmissorId,
                        principalTable: "dbSEstados",
                        principalColumn: "EstadoId");
                    table.ForeignKey(
                        name: "FK_DocumentoPessoa_dbSEstados_RG_EstadoEmissorId",
                        column: x => x.RG_EstadoEmissorId,
                        principalTable: "dbSEstados",
                        principalColumn: "EstadoId");
                });

            migrationBuilder.CreateTable(
                name: "Economia_Entidade",
                columns: table => new
                {
                    ImovelId = table.Column<long>(type: "bigint", nullable: false),
                    EconomiaId = table.Column<long>(type: "bigint", nullable: false),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    TipoResponsabilidadeId = table.Column<int>(type: "int", nullable: true),
                    Proprietario = table.Column<bool>(type: "bit", nullable: true),
                    Responsavel = table.Column<bool>(type: "bit", nullable: true),
                    CoResponsavel = table.Column<bool>(type: "bit", nullable: true),
                    Locatario = table.Column<bool>(type: "bit", nullable: true),
                    Correspondente = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economia_Entidade", x => new { x.ImovelId, x.EconomiaId, x.PessoaId });
                    table.ForeignKey(
                        name: "FK_Economia_Entidade_Economia_ImovelId_EconomiaId",
                        columns: x => new { x.ImovelId, x.EconomiaId },
                        principalTable: "Economia",
                        principalColumns: new[] { "ImovelId", "EconomiaId" });
                    table.ForeignKey(
                        name: "FK_Economia_Entidade_Imovel_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imovel",
                        principalColumn: "ImovelId");
                    table.ForeignKey(
                        name: "FK_Economia_Entidade_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId");
                    table.ForeignKey(
                        name: "FK_Economia_Entidade_TipoResponsabilidade_TipoResponsabilidadeId",
                        column: x => x.TipoResponsabilidadeId,
                        principalTable: "TipoResponsabilidade",
                        principalColumn: "TipoResponsabilidadeId");
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    PrimeiroNome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    NomeMeio = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Sobrenome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataObito = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DefinicaoSexual = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_PessoaFisica_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaFisica_dbSPaises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "dbSPaises",
                        principalColumn: "PaisId");
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    RazaoSocial = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    NomeFantasia = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    InscricaoEstadual = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_PessoaJuridica_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processo",
                columns: table => new
                {
                    OrgaoId = table.Column<int>(type: "int", nullable: false),
                    SequenciaNumerica = table.Column<long>(type: "bigint", nullable: false),
                    Ano = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DigitoVerificador = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoProcessoId = table.Column<int>(type: "int", nullable: false),
                    OrgaoRemetenteId = table.Column<int>(type: "int", nullable: false),
                    UnidadeRemetenteId = table.Column<int>(type: "int", nullable: false),
                    OrgaoDestinatarioId = table.Column<int>(type: "int", nullable: false),
                    UnidadeDestinatarioId = table.Column<int>(type: "int", nullable: false),
                    FluxoProcessoId = table.Column<int>(type: "int", nullable: false),
                    ObservacaoProcesso = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ProcessoEnviado = table.Column<bool>(type: "bit", nullable: false),
                    ProcessoRecebido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processo", x => new { x.OrgaoId, x.SequenciaNumerica, x.Ano, x.DigitoVerificador });
                    table.ForeignKey(
                        name: "FK_Processo_FluxoProcesso_FluxoProcessoId",
                        column: x => x.FluxoProcessoId,
                        principalTable: "FluxoProcesso",
                        principalColumn: "FluxoProcessoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processo_Orgao_OrgaoDestinatarioId",
                        column: x => x.OrgaoDestinatarioId,
                        principalTable: "Orgao",
                        principalColumn: "OrgaoId");
                    table.ForeignKey(
                        name: "FK_Processo_Orgao_OrgaoId",
                        column: x => x.OrgaoId,
                        principalTable: "Orgao",
                        principalColumn: "OrgaoId");
                    table.ForeignKey(
                        name: "FK_Processo_Orgao_OrgaoRemetenteId",
                        column: x => x.OrgaoRemetenteId,
                        principalTable: "Orgao",
                        principalColumn: "OrgaoId");
                    table.ForeignKey(
                        name: "FK_Processo_TipoProcesso_TipoProcessoId",
                        column: x => x.TipoProcessoId,
                        principalTable: "TipoProcesso",
                        principalColumn: "TipoProcessoId");
                    table.ForeignKey(
                        name: "FK_Processo_Unidade_UnidadeDestinatarioId",
                        column: x => x.UnidadeDestinatarioId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId");
                    table.ForeignKey(
                        name: "FK_Processo_Unidade_UnidadeRemetenteId",
                        column: x => x.UnidadeRemetenteId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId");
                });

            migrationBuilder.CreateTable(
                name: "Contato_Pessoa",
                columns: table => new
                {
                    ContatoId = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato_Pessoa", x => new { x.ContatoId, x.PessoaId });
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa_Contato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contato",
                        principalColumn: "ContatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbSRegioes",
                columns: table => new
                {
                    RegiaoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true),
                    CidadeId = table.Column<int>(type: "int", nullable: true),
                    PercentualUVC = table.Column<float>(type: "real", nullable: true),
                    CentroGrauLon = table.Column<string>(type: "varchar", nullable: true),
                    CentroGrauLat = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSRegioes", x => x.RegiaoId);
                    table.ForeignKey(
                        name: "FK_dbSRegioes_dbSCidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "dbSCidades",
                        principalColumn: "CidadeId");
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<string>(type: "varchar", nullable: false),
                    ImageBase64String = table.Column<string>(type: "varchar", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcessoId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessoOrgaoId = table.Column<int>(type: "int", nullable: true),
                    ProcessoSequenciaNumerica = table.Column<long>(type: "bigint", nullable: true),
                    ProcessoAno = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcessoDigitoVerificador = table.Column<int>(type: "int", nullable: true),
                    TipoProcessoId = table.Column<int>(type: "int", nullable: true),
                    SituacaoProcessoId = table.Column<int>(type: "int", nullable: true),
                    ImovelId = table.Column<long>(type: "bigint", nullable: true),
                    EconomiaId = table.Column<long>(type: "bigint", nullable: true),
                    SituacaoEtapaId = table.Column<int>(type: "int", nullable: true),
                    TipoEtapaId = table.Column<int>(type: "int", nullable: true),
                    PerspectivaId = table.Column<int>(type: "int", nullable: true),
                    NomeArquivo = table.Column<string>(type: "varchar", nullable: true),
                    Caminho = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Image_Imovel_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imovel",
                        principalColumn: "ImovelId");
                    table.ForeignKey(
                        name: "FK_Image_Perspectiva_PerspectivaId",
                        column: x => x.PerspectivaId,
                        principalTable: "Perspectiva",
                        principalColumn: "PerspectivaId");
                    table.ForeignKey(
                        name: "FK_Image_Processo_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                        columns: x => new { x.ProcessoOrgaoId, x.ProcessoSequenciaNumerica, x.ProcessoAno, x.ProcessoDigitoVerificador },
                        principalTable: "Processo",
                        principalColumns: new[] { "OrgaoId", "SequenciaNumerica", "Ano", "DigitoVerificador" });
                    table.ForeignKey(
                        name: "FK_Image_SituacaoEtapa_SituacaoEtapaId",
                        column: x => x.SituacaoEtapaId,
                        principalTable: "SituacaoEtapa",
                        principalColumn: "SituacaoEtapaId");
                    table.ForeignKey(
                        name: "FK_Image_SituacaoProcesso_SituacaoProcessoId",
                        column: x => x.SituacaoProcessoId,
                        principalTable: "SituacaoProcesso",
                        principalColumn: "SituacaoProcessoId");
                    table.ForeignKey(
                        name: "FK_Image_TipoEtapa_TipoEtapaId",
                        column: x => x.TipoEtapaId,
                        principalTable: "TipoEtapa",
                        principalColumn: "TipoEtapaId");
                    table.ForeignKey(
                        name: "FK_Image_TipoProcesso_TipoProcessoId",
                        column: x => x.TipoProcessoId,
                        principalTable: "TipoProcesso",
                        principalColumn: "TipoProcessoId");
                });

            migrationBuilder.CreateTable(
                name: "dbSBairros",
                columns: table => new
                {
                    BairroId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true),
                    RegiaoId = table.Column<long>(type: "bigint", nullable: true),
                    CidadeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSBairros", x => x.BairroId);
                    table.ForeignKey(
                        name: "FK_dbSBairros_dbSCidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "dbSCidades",
                        principalColumn: "CidadeId");
                    table.ForeignKey(
                        name: "FK_dbSBairros_dbSRegioes_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "dbSRegioes",
                        principalColumn: "RegiaoId");
                });

            migrationBuilder.CreateTable(
                name: "Loteamento",
                columns: table => new
                {
                    LoteamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true),
                    RegiaoId = table.Column<int>(type: "int", nullable: true),
                    RegiaoId1 = table.Column<long>(type: "bigint", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loteamento", x => x.LoteamentoId);
                    table.ForeignKey(
                        name: "FK_Loteamento_dbSRegioes_RegiaoId1",
                        column: x => x.RegiaoId1,
                        principalTable: "dbSRegioes",
                        principalColumn: "RegiaoId");
                });

            migrationBuilder.CreateTable(
                name: "dbSLogradouros",
                columns: table => new
                {
                    LogradouroId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar", nullable: true),
                    CidadeId = table.Column<int>(type: "int", nullable: true),
                    BairroId = table.Column<long>(type: "bigint", nullable: true),
                    TipoLogradouroId = table.Column<int>(type: "int", nullable: true),
                    CEP = table.Column<string>(type: "varchar", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSLogradouros", x => x.LogradouroId);
                    table.ForeignKey(
                        name: "FK_dbSLogradouros_dbSBairros_BairroId",
                        column: x => x.BairroId,
                        principalTable: "dbSBairros",
                        principalColumn: "BairroId");
                    table.ForeignKey(
                        name: "FK_dbSLogradouros_dbSCidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "dbSCidades",
                        principalColumn: "CidadeId");
                    table.ForeignKey(
                        name: "FK_dbSLogradouros_dbSTiposLogradouro_TipoLogradouroId",
                        column: x => x.TipoLogradouroId,
                        principalTable: "dbSTiposLogradouro",
                        principalColumn: "TipoLogradouroId");
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidadeId = table.Column<int>(type: "int", nullable: true),
                    LogradouroId = table.Column<long>(type: "bigint", nullable: true),
                    BairroId = table.Column<long>(type: "bigint", nullable: true),
                    Complemento = table.Column<string>(type: "varchar", nullable: true),
                    Referencia = table.Column<string>(type: "varchar", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_Endereco_dbSBairros_BairroId",
                        column: x => x.BairroId,
                        principalTable: "dbSBairros",
                        principalColumn: "BairroId");
                    table.ForeignKey(
                        name: "FK_Endereco_dbSCidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "dbSCidades",
                        principalColumn: "CidadeId");
                    table.ForeignKey(
                        name: "FK_Endereco_dbSLogradouros_LogradouroId",
                        column: x => x.LogradouroId,
                        principalTable: "dbSLogradouros",
                        principalColumn: "LogradouroId");
                });

            migrationBuilder.CreateTable(
                name: "Endereco_Entidade",
                columns: table => new
                {
                    EntidadeId = table.Column<long>(type: "bigint", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    TipoEntidadeId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    DataUltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CEP = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Correnspondencia = table.Column<bool>(type: "bit", nullable: true),
                    Principal = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Correspondencia = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EconomiaId = table.Column<long>(type: "bigint", nullable: true),
                    EconomiaImovelId = table.Column<long>(type: "bigint", nullable: true),
                    ImovelId = table.Column<long>(type: "bigint", nullable: true),
                    PessoaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco_Entidade", x => new { x.EntidadeId, x.EnderecoId, x.TipoEntidadeId, x.Numero });
                    table.ForeignKey(
                        name: "FK_Endereco_Entidade_Economia_EconomiaImovelId_EconomiaId",
                        columns: x => new { x.EconomiaImovelId, x.EconomiaId },
                        principalTable: "Economia",
                        principalColumns: new[] { "ImovelId", "EconomiaId" });
                    table.ForeignKey(
                        name: "FK_Endereco_Entidade_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_Entidade_Imovel_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imovel",
                        principalColumn: "ImovelId");
                    table.ForeignKey(
                        name: "FK_Endereco_Entidade_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId");
                });

            migrationBuilder.CreateTable(
                name: "Etapa",
                columns: table => new
                {
                    ProcessoId = table.Column<long>(type: "bigint", nullable: false),
                    SituacaoEtapaId = table.Column<int>(type: "int", nullable: false),
                    ImovelId = table.Column<long>(type: "bigint", nullable: false),
                    EconomiaId = table.Column<long>(type: "bigint", nullable: false),
                    TipoEtapaId = table.Column<int>(type: "int", nullable: false),
                    EtapaId = table.Column<int>(type: "int", nullable: false),
                    ProcessoOrgaoId = table.Column<int>(type: "int", nullable: true),
                    ProcessoSequenciaNumerica = table.Column<long>(type: "bigint", nullable: true),
                    ProcessoAno = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcessoDigitoVerificador = table.Column<int>(type: "int", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServidorId = table.Column<long>(type: "bigint", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: true),
                    PessoaId = table.Column<long>(type: "bigint", nullable: true),
                    PessoaProprietariaResponsavelId = table.Column<long>(type: "bigint", nullable: true),
                    PessoaTerceiraID = table.Column<long>(type: "bigint", nullable: true),
                    Ano = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: true),
                    antigo = table.Column<bool>(type: "bit", nullable: true),
                    protocolo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    anoprotocolo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Observacao = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: true),
                    emailEnviado = table.Column<bool>(type: "bit", nullable: true),
                    emailRecebido = table.Column<bool>(type: "bit", nullable: true),
                    whatsEnviado = table.Column<bool>(type: "bit", nullable: true),
                    whatsRecebido = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapa", x => new { x.ProcessoId, x.TipoEtapaId, x.SituacaoEtapaId, x.ImovelId, x.EconomiaId });
                    table.ForeignKey(
                        name: "FK_Etapa_Economia_ImovelId_EconomiaId",
                        columns: x => new { x.ImovelId, x.EconomiaId },
                        principalTable: "Economia",
                        principalColumns: new[] { "ImovelId", "EconomiaId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etapa_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId");
                    table.ForeignKey(
                        name: "FK_Etapa_Imovel_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imovel",
                        principalColumn: "ImovelId");
                    table.ForeignKey(
                        name: "FK_Etapa_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId");
                    table.ForeignKey(
                        name: "FK_Etapa_Pessoa_PessoaProprietariaResponsavelId",
                        column: x => x.PessoaProprietariaResponsavelId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId");
                    table.ForeignKey(
                        name: "FK_Etapa_Pessoa_PessoaTerceiraID",
                        column: x => x.PessoaTerceiraID,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId");
                    table.ForeignKey(
                        name: "FK_Etapa_Processo_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                        columns: x => new { x.ProcessoOrgaoId, x.ProcessoSequenciaNumerica, x.ProcessoAno, x.ProcessoDigitoVerificador },
                        principalTable: "Processo",
                        principalColumns: new[] { "OrgaoId", "SequenciaNumerica", "Ano", "DigitoVerificador" });
                    table.ForeignKey(
                        name: "FK_Etapa_Servidor_ServidorId",
                        column: x => x.ServidorId,
                        principalTable: "Servidor",
                        principalColumn: "ServidorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etapa_SituacaoEtapa_SituacaoEtapaId",
                        column: x => x.SituacaoEtapaId,
                        principalTable: "SituacaoEtapa",
                        principalColumn: "SituacaoEtapaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etapa_TipoEtapa_TipoEtapaId",
                        column: x => x.TipoEtapaId,
                        principalTable: "TipoEtapa",
                        principalColumn: "TipoEtapaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SituacaoEtapa",
                columns: new[] { "SituacaoEtapaId", "Descricao" },
                values: new object[,]
                {
                    { 1, "Iniciado" },
                    { 2, "Finalizado" },
                    { 3, "Trâmite" }
                });

            migrationBuilder.InsertData(
                table: "SituacaoProcesso",
                columns: new[] { "SituacaoProcessoId", "Descricao" },
                values: new object[,]
                {
                    { 1, "Iniciado" },
                    { 2, "Finalizado" }
                });

            migrationBuilder.InsertData(
                table: "TipoPessoa",
                columns: new[] { "TipoPessoaId", "Descricao" },
                values: new object[,]
                {
                    { 1, "FÍSICA" },
                    { 2, "JURÍDICA" }
                });

            migrationBuilder.InsertData(
                table: "TipoResponsabilidade",
                columns: new[] { "TipoResponsabilidadeId", "Descricao" },
                values: new object[,]
                {
                    { 1, "Proprietário" },
                    { 2, "Responsável" },
                    { 3, "Co-Responsável" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_DDDId",
                table: "Contato",
                column: "DDDId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_OperadoraTelefoneId",
                table: "Contato",
                column: "OperadoraTelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_TipoContatoId",
                table: "Contato",
                column: "TipoContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_TipoTelefoneId",
                table: "Contato",
                column: "TipoTelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_Pessoa_PessoaId",
                table: "Contato_Pessoa",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSBairros_CidadeId",
                table: "dbSBairros",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSBairros_RegiaoId",
                table: "dbSBairros",
                column: "RegiaoId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSCidades_DDDId",
                table: "dbSCidades",
                column: "DDDId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSCidades_EstadoId",
                table: "dbSCidades",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSEstados_PaisId",
                table: "dbSEstados",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSLogradouros_BairroId",
                table: "dbSLogradouros",
                column: "BairroId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSLogradouros_CidadeId",
                table: "dbSLogradouros",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSLogradouros_TipoLogradouroId",
                table: "dbSLogradouros",
                column: "TipoLogradouroId");

            migrationBuilder.CreateIndex(
                name: "IX_dbSRegioes_CidadeId",
                table: "dbSRegioes",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoPessoa_CNPJ_EstadoEmissorId",
                table: "DocumentoPessoa",
                column: "CNPJ_EstadoEmissorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoPessoa_EstadoEmissorId",
                table: "DocumentoPessoa",
                column: "EstadoEmissorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoPessoa_PessoaId",
                table: "DocumentoPessoa",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoPessoa_RG_EstadoEmissorId",
                table: "DocumentoPessoa",
                column: "RG_EstadoEmissorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoPessoa_TipoDocumentoId",
                table: "DocumentoPessoa",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Economia_Entidade_PessoaId",
                table: "Economia_Entidade",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Economia_Entidade_TipoResponsabilidadeId",
                table: "Economia_Entidade",
                column: "TipoResponsabilidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_BairroId",
                table: "Endereco",
                column: "BairroId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CidadeId",
                table: "Endereco",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_LogradouroId",
                table: "Endereco",
                column: "LogradouroId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Entidade_EconomiaImovelId_EconomiaId",
                table: "Endereco_Entidade",
                columns: new[] { "EconomiaImovelId", "EconomiaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Entidade_EnderecoId",
                table: "Endereco_Entidade",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Entidade_ImovelId",
                table: "Endereco_Entidade",
                column: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Entidade_PessoaId",
                table: "Endereco_Entidade",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_EnderecoId",
                table: "Etapa",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_ImovelId_EconomiaId",
                table: "Etapa",
                columns: new[] { "ImovelId", "EconomiaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PessoaId",
                table: "Etapa",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PessoaProprietariaResponsavelId",
                table: "Etapa",
                column: "PessoaProprietariaResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PessoaTerceiraID",
                table: "Etapa",
                column: "PessoaTerceiraID");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Etapa",
                columns: new[] { "ProcessoOrgaoId", "ProcessoSequenciaNumerica", "ProcessoAno", "ProcessoDigitoVerificador" });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_ServidorId",
                table: "Etapa",
                column: "ServidorId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_SituacaoEtapaId",
                table: "Etapa",
                column: "SituacaoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_TipoEtapaId",
                table: "Etapa",
                column: "TipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_FluxoProcesso_TipoEtapaId",
                table: "FluxoProcesso",
                column: "TipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_FluxoProcesso_TipoProcessoId",
                table: "FluxoProcesso",
                column: "TipoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ImovelId",
                table: "Image",
                column: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_PerspectivaId",
                table: "Image",
                column: "PerspectivaId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Image",
                columns: new[] { "ProcessoOrgaoId", "ProcessoSequenciaNumerica", "ProcessoAno", "ProcessoDigitoVerificador" });

            migrationBuilder.CreateIndex(
                name: "IX_Image_SituacaoEtapaId",
                table: "Image",
                column: "SituacaoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_SituacaoProcessoId",
                table: "Image",
                column: "SituacaoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TipoEtapaId",
                table: "Image",
                column: "TipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TipoProcessoId",
                table: "Image",
                column: "TipoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Loteamento_RegiaoId1",
                table: "Loteamento",
                column: "RegiaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TipoPessoaId",
                table: "Pessoa",
                column: "TipoPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFisica_PaisId",
                table: "PessoaFisica",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_FluxoProcessoId",
                table: "Processo",
                column: "FluxoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_OrgaoDestinatarioId",
                table: "Processo",
                column: "OrgaoDestinatarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_OrgaoRemetenteId",
                table: "Processo",
                column: "OrgaoRemetenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_TipoProcessoId",
                table: "Processo",
                column: "TipoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_UnidadeDestinatarioId",
                table: "Processo",
                column: "UnidadeDestinatarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_UnidadeRemetenteId",
                table: "Processo",
                column: "UnidadeRemetenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Unidade_OrgaoId",
                table: "Unidade",
                column: "OrgaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contato_Pessoa");

            migrationBuilder.DropTable(
                name: "DocumentoPessoa");

            migrationBuilder.DropTable(
                name: "Economia_Entidade");

            migrationBuilder.DropTable(
                name: "Endereco_Entidade");

            migrationBuilder.DropTable(
                name: "Etapa");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "IncrementoTabelas");

            migrationBuilder.DropTable(
                name: "Loteamento");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "TipoResponsabilidade");

            migrationBuilder.DropTable(
                name: "Economia");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Servidor");

            migrationBuilder.DropTable(
                name: "Perspectiva");

            migrationBuilder.DropTable(
                name: "Processo");

            migrationBuilder.DropTable(
                name: "SituacaoEtapa");

            migrationBuilder.DropTable(
                name: "SituacaoProcesso");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "OperadoraTelefone");

            migrationBuilder.DropTable(
                name: "TipoContato");

            migrationBuilder.DropTable(
                name: "TipoTelefone");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "dbSLogradouros");

            migrationBuilder.DropTable(
                name: "FluxoProcesso");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "TipoPessoa");

            migrationBuilder.DropTable(
                name: "dbSBairros");

            migrationBuilder.DropTable(
                name: "dbSTiposLogradouro");

            migrationBuilder.DropTable(
                name: "TipoEtapa");

            migrationBuilder.DropTable(
                name: "TipoProcesso");

            migrationBuilder.DropTable(
                name: "Orgao");

            migrationBuilder.DropTable(
                name: "dbSRegioes");

            migrationBuilder.DropTable(
                name: "dbSCidades");

            migrationBuilder.DropTable(
                name: "DDD");

            migrationBuilder.DropTable(
                name: "dbSEstados");

            migrationBuilder.DropTable(
                name: "dbSPaises");
        }
    }
}
