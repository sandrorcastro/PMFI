using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class OrgaoUnidadeDivisaoServidore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DivisaoId",
                table: "Servidor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeId",
                table: "Processo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Divisao",
                columns: table => new
                {
                    DivisaoId = table.Column<int>(type: "int", nullable: false),
                    UnidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisao", x => x.DivisaoId);
                    table.ForeignKey(
                        name: "FK_Divisao_Unidade_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servidor_DivisaoId",
                table: "Servidor",
                column: "DivisaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_UnidadeId",
                table: "Processo",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisao_UnidadeId",
                table: "Divisao",
                column: "UnidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Unidade_UnidadeId",
                table: "Processo",
                column: "UnidadeId",
                principalTable: "Unidade",
                principalColumn: "UnidadeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servidor_Divisao_DivisaoId",
                table: "Servidor",
                column: "DivisaoId",
                principalTable: "Divisao",
                principalColumn: "DivisaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Unidade_UnidadeId",
                table: "Processo");

            migrationBuilder.DropForeignKey(
                name: "FK_Servidor_Divisao_DivisaoId",
                table: "Servidor");

            migrationBuilder.DropTable(
                name: "Divisao");

            migrationBuilder.DropIndex(
                name: "IX_Servidor_DivisaoId",
                table: "Servidor");

            migrationBuilder.DropIndex(
                name: "IX_Processo_UnidadeId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "DivisaoId",
                table: "Servidor");

            migrationBuilder.DropColumn(
                name: "UnidadeId",
                table: "Processo");
        }
    }
}
