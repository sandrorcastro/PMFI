using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjuesteEtapa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ProcessoInativo",
                table: "Processo",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ServidorExecutorId",
                table: "Processo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EtapaInativa",
                table: "Etapa",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processo_ServidorExecutorId",
                table: "Processo",
                column: "ServidorExecutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Servidor_ServidorExecutorId",
                table: "Processo",
                column: "ServidorExecutorId",
                principalTable: "Servidor",
                principalColumn: "ServidorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Servidor_ServidorExecutorId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_ServidorExecutorId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "ProcessoInativo",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "ServidorExecutorId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "EtapaInativa",
                table: "Etapa");
        }
    }
}
