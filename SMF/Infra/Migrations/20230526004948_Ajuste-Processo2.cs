using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjusteProcesso2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EconomiaId",
                table: "Processo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ImovelId",
                table: "Processo",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processo_ImovelId_EconomiaId",
                table: "Processo",
                columns: new[] { "ImovelId", "EconomiaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Economia_ImovelId_EconomiaId",
                table: "Processo",
                columns: new[] { "ImovelId", "EconomiaId" },
                principalTable: "Economia",
                principalColumns: new[] { "ImovelId", "EconomiaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Imovel_ImovelId",
                table: "Processo",
                column: "ImovelId",
                principalTable: "Imovel",
                principalColumn: "ImovelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Economia_ImovelId_EconomiaId",
                table: "Processo");

            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Imovel_ImovelId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_ImovelId_EconomiaId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "EconomiaId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "ImovelId",
                table: "Processo");
        }
    }
}
