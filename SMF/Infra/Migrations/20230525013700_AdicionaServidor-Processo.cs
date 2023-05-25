using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaServidorProcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "Etapa",
                newName: "ObservacaoEtapa");

            migrationBuilder.AddColumn<long>(
                name: "ServidorId",
                table: "Processo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Processo_ServidorId",
                table: "Processo",
                column: "ServidorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Servidor_ServidorId",
                table: "Processo",
                column: "ServidorId",
                principalTable: "Servidor",
                principalColumn: "ServidorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Servidor_ServidorId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_ServidorId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "ServidorId",
                table: "Processo");

            migrationBuilder.RenameColumn(
                name: "ObservacaoEtapa",
                table: "Etapa",
                newName: "Observacao");
        }
    }
}
