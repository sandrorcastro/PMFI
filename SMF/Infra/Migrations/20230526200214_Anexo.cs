using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Anexo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Pessoa_PessoaProprietariaResponsavelId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Pessoa_PessoaTerceiraID",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_TipoEtapa_TipoEtapaId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_FluxoProcesso_TipoEtapa_TipoEtapaId",
                table: "FluxoProcesso");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso");

            migrationBuilder.DropIndex(
                name: "IX_FluxoProcesso_TipoEtapaId",
                table: "FluxoProcesso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_PessoaProprietariaResponsavelId",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_PessoaTerceiraID",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_TipoEtapaId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "Sequencia",
                table: "FluxoProcesso");

            migrationBuilder.DropColumn(
                name: "TipoEtapaId",
                table: "FluxoProcesso");

            migrationBuilder.DropColumn(
                name: "PessoaProprietariaResponsavelId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "PessoaTerceiraID",
                table: "Etapa");

            migrationBuilder.RenameColumn(
                name: "EtapaId",
                table: "Etapa",
                newName: "TipoProcessoId");

            migrationBuilder.RenameColumn(
                name: "TipoEtapaId",
                table: "Etapa",
                newName: "FluxoProcessoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso",
                columns: new[] { "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa",
                columns: new[] { "ProcessoId", "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.CreateTable(
                name: "Anexo",
                columns: table => new
                {
                    ProcessoId = table.Column<long>(type: "bigint", nullable: false),
                    FluxoProcessoId = table.Column<int>(type: "int", nullable: false),
                    TipoProcessoId = table.Column<int>(type: "int", nullable: false),
                    AnexoId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ImageBase64String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    NomeArquivo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Caminho = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TipoAnexo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => new { x.ProcessoId, x.FluxoProcessoId, x.TipoProcessoId, x.AnexoId });
                    table.ForeignKey(
                        name: "FK_Anexo_Etapa_ProcessoId_FluxoProcessoId_TipoProcessoId",
                        columns: x => new { x.ProcessoId, x.FluxoProcessoId, x.TipoProcessoId },
                        principalTable: "Etapa",
                        principalColumns: new[] { "ProcessoId", "FluxoProcessoId", "TipoProcessoId" });
                    table.ForeignKey(
                        name: "FK_Anexo_FluxoProcesso_FluxoProcessoId_TipoProcessoId",
                        columns: x => new { x.FluxoProcessoId, x.TipoProcessoId },
                        principalTable: "FluxoProcesso",
                        principalColumns: new[] { "FluxoProcessoId", "TipoProcessoId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Anexo_Processo_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processo",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Anexo_TipoProcesso_TipoProcessoId",
                        column: x => x.TipoProcessoId,
                        principalTable: "TipoProcesso",
                        principalColumn: "TipoProcessoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_FluxoProcessoId_TipoProcessoId",
                table: "Etapa",
                columns: new[] { "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_TipoProcessoId",
                table: "Etapa",
                column: "TipoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_FluxoProcessoId_TipoProcessoId",
                table: "Anexo",
                columns: new[] { "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_TipoProcessoId",
                table: "Anexo",
                column: "TipoProcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_FluxoProcesso_FluxoProcessoId_TipoProcessoId",
                table: "Etapa",
                columns: new[] { "FluxoProcessoId", "TipoProcessoId" },
                principalTable: "FluxoProcesso",
                principalColumns: new[] { "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_TipoProcesso_TipoProcessoId",
                table: "Etapa",
                column: "TipoProcessoId",
                principalTable: "TipoProcesso",
                principalColumn: "TipoProcessoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_FluxoProcesso_FluxoProcessoId_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_TipoProcesso_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.DropTable(
                name: "Anexo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_FluxoProcessoId_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.RenameColumn(
                name: "TipoProcessoId",
                table: "Etapa",
                newName: "EtapaId");

            migrationBuilder.RenameColumn(
                name: "FluxoProcessoId",
                table: "Etapa",
                newName: "TipoEtapaId");

            migrationBuilder.AddColumn<int>(
                name: "Sequencia",
                table: "FluxoProcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoEtapaId",
                table: "FluxoProcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "PessoaProprietariaResponsavelId",
                table: "Etapa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PessoaTerceiraID",
                table: "Etapa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso",
                column: "FluxoProcessoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa",
                columns: new[] { "ProcessoId", "TipoEtapaId" });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ImovelId = table.Column<long>(type: "bigint", nullable: true),
                    PerspectivaId = table.Column<int>(type: "int", nullable: true),
                    ProcessoId = table.Column<long>(type: "bigint", nullable: true),
                    SituacaoEtapaId = table.Column<int>(type: "int", nullable: true),
                    SituacaoProcessoId = table.Column<int>(type: "int", nullable: true),
                    TipoEtapaId = table.Column<int>(type: "int", nullable: true),
                    TipoProcessoId = table.Column<int>(type: "int", nullable: true),
                    Caminho = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    EconomiaId = table.Column<long>(type: "bigint", nullable: true),
                    ImageBase64String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeArquivo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
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
                        name: "FK_Image_Processo_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processo",
                        principalColumn: "ProcessoId");
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

            migrationBuilder.CreateIndex(
                name: "IX_FluxoProcesso_TipoEtapaId",
                table: "FluxoProcesso",
                column: "TipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PessoaProprietariaResponsavelId",
                table: "Etapa",
                column: "PessoaProprietariaResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PessoaTerceiraID",
                table: "Etapa",
                column: "PessoaTerceiraID");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_TipoEtapaId",
                table: "Etapa",
                column: "TipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ImovelId",
                table: "Image",
                column: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_PerspectivaId",
                table: "Image",
                column: "PerspectivaId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProcessoId",
                table: "Image",
                column: "ProcessoId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Pessoa_PessoaProprietariaResponsavelId",
                table: "Etapa",
                column: "PessoaProprietariaResponsavelId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Pessoa_PessoaTerceiraID",
                table: "Etapa",
                column: "PessoaTerceiraID",
                principalTable: "Pessoa",
                principalColumn: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_TipoEtapa_TipoEtapaId",
                table: "Etapa",
                column: "TipoEtapaId",
                principalTable: "TipoEtapa",
                principalColumn: "TipoEtapaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluxoProcesso_TipoEtapa_TipoEtapaId",
                table: "FluxoProcesso",
                column: "TipoEtapaId",
                principalTable: "TipoEtapa",
                principalColumn: "TipoEtapaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
