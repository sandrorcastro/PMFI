using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjustesEtapa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Servidor_ServidorId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_SituacaoEtapa_SituacaoEtapaId",
                table: "Etapa");

            migrationBuilder.AlterColumn<int>(
                name: "SituacaoEtapaId",
                table: "Etapa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ServidorId",
                table: "Etapa",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Servidor_ServidorId",
                table: "Etapa",
                column: "ServidorId",
                principalTable: "Servidor",
                principalColumn: "ServidorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_SituacaoEtapa_SituacaoEtapaId",
                table: "Etapa",
                column: "SituacaoEtapaId",
                principalTable: "SituacaoEtapa",
                principalColumn: "SituacaoEtapaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Servidor_ServidorId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_SituacaoEtapa_SituacaoEtapaId",
                table: "Etapa");

            migrationBuilder.AlterColumn<int>(
                name: "SituacaoEtapaId",
                table: "Etapa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ServidorId",
                table: "Etapa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Servidor_ServidorId",
                table: "Etapa",
                column: "ServidorId",
                principalTable: "Servidor",
                principalColumn: "ServidorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_SituacaoEtapa_SituacaoEtapaId",
                table: "Etapa",
                column: "SituacaoEtapaId",
                principalTable: "SituacaoEtapa",
                principalColumn: "SituacaoEtapaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
