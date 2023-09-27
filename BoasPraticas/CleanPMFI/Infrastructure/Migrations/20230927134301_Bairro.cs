using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Bairro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bairro",
                columns: table => new
                {
                    IdBairro = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IdRegiao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairro", x => x.IdBairro);
                    table.ForeignKey(
                        name: "FK_Bairro_Regiao_IdRegiao",
                        column: x => x.IdRegiao,
                        principalTable: "Regiao",
                        principalColumn: "IdRegiao");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bairro_IdRegiao",
                table: "Bairro",
                column: "IdRegiao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bairro");
        }
    }
}
