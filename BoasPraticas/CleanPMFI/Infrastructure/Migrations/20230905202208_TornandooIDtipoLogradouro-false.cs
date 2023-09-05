using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class TornandooIDtipoLogradourofalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logradouro_TipoLogradouro_IdTipoLogradouro",
                table: "Logradouro");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoLogradouro",
                table: "Logradouro",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Logradouro_TipoLogradouro_IdTipoLogradouro",
                table: "Logradouro",
                column: "IdTipoLogradouro",
                principalTable: "TipoLogradouro",
                principalColumn: "IdTipoLogadouro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logradouro_TipoLogradouro_IdTipoLogradouro",
                table: "Logradouro");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoLogradouro",
                table: "Logradouro",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Logradouro_TipoLogradouro_IdTipoLogradouro",
                table: "Logradouro",
                column: "IdTipoLogradouro",
                principalTable: "TipoLogradouro",
                principalColumn: "IdTipoLogadouro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
