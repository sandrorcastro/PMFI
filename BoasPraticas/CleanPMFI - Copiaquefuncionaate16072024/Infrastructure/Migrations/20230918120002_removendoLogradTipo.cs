using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class removendoLogradTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogradTipo",
                table: "Logradouro");

            migrationBuilder.CreateTable(
                name: "tribAlvDocumento",
                columns: table => new
                {
                    idDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nrAno = table.Column<short>(type: "smallint", nullable: true),
                    nrSequencia = table.Column<int>(type: "int", nullable: true),
                    nrCMC_Execucao = table.Column<long>(type: "bigint", nullable: true),
                    nrCMC_Projeto = table.Column<long>(type: "bigint", nullable: true),
                    dsObraEndereco = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    dsObra = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nrART = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nrCREA_Execucao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nrCREA_Projeto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nmProprietario = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nrPropCPFCNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    dsPropFone = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    dsPropEndereco = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    dsArea = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nrInscricao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    dtDocumento = table.Column<DateTime>(type: "date", nullable: true),
                    nrNossoNumero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    flComValor = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    nrProtocolo = table.Column<int>(type: "int", nullable: true),
                    nrLote = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    nrQuadra = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dsObservacao = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    dsAvaliacaoISSQN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    imDocumento = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    dsTipoDocumento = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    dsTitulo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    dsTexto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    idDocumentoOrigem = table.Column<int>(type: "int", nullable: true),
                    nrAreaTerreno = table.Column<decimal>(type: "money", nullable: true),
                    nrSequenciaOrigem = table.Column<int>(type: "int", nullable: true),
                    nrAnoOrigem = table.Column<short>(type: "smallint", nullable: true),
                    dispensado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    cepObra = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    cepProprietario = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    vlTotalAreaConstrucao = table.Column<decimal>(type: "money", nullable: true),
                    flOutorga = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    vlVenalTerreno = table.Column<decimal>(type: "money", nullable: true),
                    vlAreaInfracionadaTerreno = table.Column<decimal>(type: "money", nullable: true),
                    vlTaxaOutorga = table.Column<decimal>(type: "money", nullable: true),
                    dsInscricaoEstatual = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    situacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dsMotivoCancelamento = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    refAnterior = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    dsDescAreaConstrucao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    dtExclusaoAlvara = table.Column<DateTime>(type: "datetime", nullable: true),
                    dsUsuarioExclusao = table.Column<string>(type: "varchar(31)", unicode: false, maxLength: 31, nullable: true),
                    idCPFCNPJ_Execucao = table.Column<int>(type: "int", nullable: true),
                    idCPFCNPJ_Projeto = table.Column<int>(type: "int", nullable: true),
                    nrProcessoAno = table.Column<short>(type: "smallint", nullable: true),
                    nrProcessoSequencia = table.Column<int>(type: "int", nullable: true),
                    dsUsuarioInclusao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    flTipoAlvara = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    tpRespObraProjeto = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    tpRespObraExecucao = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tribAlvDocumento", x => x.idDocumento);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tribAlvDocumento_nrAno_nrSequencia",
                table: "tribAlvDocumento",
                columns: new[] { "nrAno", "nrSequencia" });

            migrationBuilder.CreateIndex(
                name: "IX_tribAlvDocumento_nrAno_nrSequencia_dsTipoDocumento",
                table: "tribAlvDocumento",
                columns: new[] { "nrAno", "nrSequencia", "dsTipoDocumento" });

            migrationBuilder.CreateIndex(
                name: "IX_tribAlvDocumento_nrInscricao",
                table: "tribAlvDocumento",
                column: "nrInscricao")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_tribAlvDocumento_nrPropCPFCNPJ",
                table: "tribAlvDocumento",
                column: "nrPropCPFCNPJ");

            migrationBuilder.CreateIndex(
                name: "IX_tribAlvDocumento_nrPropCPFCNPJ_nrProtocolo",
                table: "tribAlvDocumento",
                columns: new[] { "nrPropCPFCNPJ", "nrProtocolo" });

            migrationBuilder.CreateIndex(
                name: "IX_tribAlvDocumento_nrSequencia",
                table: "tribAlvDocumento",
                column: "nrSequencia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tribAlvDocumento");

            migrationBuilder.AddColumn<string>(
                name: "LogradTipo",
                table: "Logradouro",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
