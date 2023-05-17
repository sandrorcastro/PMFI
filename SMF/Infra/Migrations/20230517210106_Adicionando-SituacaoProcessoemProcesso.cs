using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoSituacaoProcessoemProcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SituacaoProcessoId",
                table: "Processo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Processo_SituacaoProcessoId",
                table: "Processo",
                column: "SituacaoProcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_SituacaoProcesso_SituacaoProcessoId",
                table: "Processo",
                column: "SituacaoProcessoId",
                principalTable: "SituacaoProcesso",
                principalColumn: "SituacaoProcessoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_SituacaoProcesso_SituacaoProcessoId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_SituacaoProcessoId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "SituacaoProcessoId",
                table: "Processo");
        }
    }
}
