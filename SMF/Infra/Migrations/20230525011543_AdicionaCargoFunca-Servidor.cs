using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaCargoFuncaServidor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Servidor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Funcao",
                table: "Servidor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeId",
                table: "Servidor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servidor_UnidadeId",
                table: "Servidor",
                column: "UnidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servidor_Unidade_UnidadeId",
                table: "Servidor",
                column: "UnidadeId",
                principalTable: "Unidade",
                principalColumn: "UnidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servidor_Unidade_UnidadeId",
                table: "Servidor");

            migrationBuilder.DropIndex(
                name: "IX_Servidor_UnidadeId",
                table: "Servidor");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Servidor");

            migrationBuilder.DropColumn(
                name: "Funcao",
                table: "Servidor");

            migrationBuilder.DropColumn(
                name: "UnidadeId",
                table: "Servidor");
        }
    }
}
