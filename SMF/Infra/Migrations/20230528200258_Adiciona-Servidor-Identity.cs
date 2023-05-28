using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaServidorIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ServidorId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ServidorId",
                table: "AspNetUsers",
                column: "ServidorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Servidor_ServidorId",
                table: "AspNetUsers",
                column: "ServidorId",
                principalTable: "Servidor",
                principalColumn: "ServidorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Servidor_ServidorId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ServidorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ServidorId",
                table: "AspNetUsers");
        }
    }
}
