using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjusteProcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Economia_ImovelId_EconomiaId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Imovel_ImovelId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Processo_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Processo_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Processo_FluxoProcesso_FluxoProcessoId",
                table: "Processo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Processo",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_FluxoProcessoId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Image_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_ImovelId_EconomiaId",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "FluxoProcessoId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "ProcessoAno",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ProcessoDigitoVerificador",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ProcessoOrgaoId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ProcessoSequenciaNumerica",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ImovelId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "EconomiaId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "ProcessoAno",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "ProcessoDigitoVerificador",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "ProcessoOrgaoId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "ProcessoSequenciaNumerica",
                table: "Etapa");

            migrationBuilder.AddColumn<long>(
                name: "ProcessoId",
                table: "Processo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Processo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Processo",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<bool>(
                name: "ProcessoAntigo",
                table: "Processo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FluxoProcesso",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Sequencia",
                table: "FluxoProcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempoTramitacao",
                table: "FluxoProcesso",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Processo",
                table: "Processo",
                column: "ProcessoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa",
                columns: new[] { "ProcessoId", "TipoEtapaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Processo_OrgaoId",
                table: "Processo",
                column: "OrgaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProcessoId",
                table: "Image",
                column: "ProcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Processo_ProcessoId",
                table: "Etapa",
                column: "ProcessoId",
                principalTable: "Processo",
                principalColumn: "ProcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Processo_ProcessoId",
                table: "Image",
                column: "ProcessoId",
                principalTable: "Processo",
                principalColumn: "ProcessoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Processo_ProcessoId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Processo_ProcessoId",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Processo",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_OrgaoId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Image_ProcessoId",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "ProcessoId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "ProcessoAntigo",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "Sequencia",
                table: "FluxoProcesso");

            migrationBuilder.DropColumn(
                name: "TempoTramitacao",
                table: "FluxoProcesso");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Processo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FluxoProcessoId",
                table: "Processo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProcessoAno",
                table: "Image",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcessoDigitoVerificador",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcessoOrgaoId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProcessoSequenciaNumerica",
                table: "Image",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FluxoProcesso",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ImovelId",
                table: "Etapa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EconomiaId",
                table: "Etapa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProcessoAno",
                table: "Etapa",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcessoDigitoVerificador",
                table: "Etapa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcessoOrgaoId",
                table: "Etapa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProcessoSequenciaNumerica",
                table: "Etapa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Processo",
                table: "Processo",
                columns: new[] { "OrgaoId", "SequenciaNumerica", "Ano", "DigitoVerificador" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa",
                columns: new[] { "ProcessoId", "TipoEtapaId", "SituacaoEtapaId", "ImovelId", "EconomiaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Processo_FluxoProcessoId",
                table: "Processo",
                column: "FluxoProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Image",
                columns: new[] { "ProcessoOrgaoId", "ProcessoSequenciaNumerica", "ProcessoAno", "ProcessoDigitoVerificador" });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_ImovelId_EconomiaId",
                table: "Etapa",
                columns: new[] { "ImovelId", "EconomiaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Etapa",
                columns: new[] { "ProcessoOrgaoId", "ProcessoSequenciaNumerica", "ProcessoAno", "ProcessoDigitoVerificador" });

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Economia_ImovelId_EconomiaId",
                table: "Etapa",
                columns: new[] { "ImovelId", "EconomiaId" },
                principalTable: "Economia",
                principalColumns: new[] { "ImovelId", "EconomiaId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Imovel_ImovelId",
                table: "Etapa",
                column: "ImovelId",
                principalTable: "Imovel",
                principalColumn: "ImovelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Processo_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Etapa",
                columns: new[] { "ProcessoOrgaoId", "ProcessoSequenciaNumerica", "ProcessoAno", "ProcessoDigitoVerificador" },
                principalTable: "Processo",
                principalColumns: new[] { "OrgaoId", "SequenciaNumerica", "Ano", "DigitoVerificador" });

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Processo_ProcessoOrgaoId_ProcessoSequenciaNumerica_ProcessoAno_ProcessoDigitoVerificador",
                table: "Image",
                columns: new[] { "ProcessoOrgaoId", "ProcessoSequenciaNumerica", "ProcessoAno", "ProcessoDigitoVerificador" },
                principalTable: "Processo",
                principalColumns: new[] { "OrgaoId", "SequenciaNumerica", "Ano", "DigitoVerificador" });

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_FluxoProcesso_FluxoProcessoId",
                table: "Processo",
                column: "FluxoProcessoId",
                principalTable: "FluxoProcesso",
                principalColumn: "FluxoProcessoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
