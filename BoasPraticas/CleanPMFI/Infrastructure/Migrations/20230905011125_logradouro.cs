using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class logradouro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    id_pais = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pais", x => x.id_pais);
                });

            migrationBuilder.CreateTable(
                name: "TipoLogradouro",
                columns: table => new
                {
                    IdTipoLogadouro = table.Column<int>(type: "int", nullable: false),
                    Dstipologradouro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoLogradouro", x => x.IdTipoLogadouro);
                });

            migrationBuilder.CreateTable(
                name: "uf",
                columns: table => new
                {
                    id_uf = table.Column<int>(type: "int", nullable: false),
                    sigla = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    id_pais = table.Column<int>(type: "int", nullable: false),
                    codigo_ibge = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_uf", x => x.id_uf);
                    table.ForeignKey(
                        name: "fk_uf_pais",
                        column: x => x.id_pais,
                        principalTable: "pais",
                        principalColumn: "id_pais");
                });

            migrationBuilder.CreateTable(
                name: "Logradouro",
                columns: table => new
                {
                    IdLogradouro = table.Column<int>(type: "int", nullable: false),
                    IdTipoLogradouro = table.Column<int>(type: "int", nullable: false),
                    LogradTipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logradouro", x => x.IdLogradouro);
                    table.ForeignKey(
                        name: "FK_Logradouro_TipoLogradouro_IdTipoLogradouro",
                        column: x => x.IdTipoLogradouro,
                        principalTable: "TipoLogradouro",
                        principalColumn: "IdTipoLogadouro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cidade",
                columns: table => new
                {
                    id_cidade = table.Column<int>(type: "int", nullable: false),
                    id_uf = table.Column<int>(type: "int", nullable: true),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    id_pais = table.Column<int>(type: "int", nullable: true),
                    codigo_ibge = table.Column<int>(type: "int", nullable: true),
                    sin_capital = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    latitude = table.Column<decimal>(type: "numeric(9,6)", nullable: true),
                    longitude = table.Column<decimal>(type: "numeric(9,6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cidade", x => x.id_cidade);
                    table.ForeignKey(
                        name: "fk_cidade_pais",
                        column: x => x.id_pais,
                        principalTable: "pais",
                        principalColumn: "id_pais");
                    table.ForeignKey(
                        name: "fk_cidade_uf",
                        column: x => x.id_uf,
                        principalTable: "uf",
                        principalColumn: "id_uf");
                });

            migrationBuilder.CreateIndex(
                name: "ak1_cidade",
                table: "cidade",
                columns: new[] { "id_uf", "nome" },
                unique: true,
                filter: "[id_uf] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "fk_cidade_pais",
                table: "cidade",
                column: "id_pais");

            migrationBuilder.CreateIndex(
                name: "fk_cidade_uf",
                table: "cidade",
                column: "id_uf");

            migrationBuilder.CreateIndex(
                name: "i01_cidade",
                table: "cidade",
                columns: new[] { "id_pais", "id_uf", "sin_capital", "codigo_ibge" });

            migrationBuilder.CreateIndex(
                name: "IX_Logradouro_IdTipoLogradouro",
                table: "Logradouro",
                column: "IdTipoLogradouro");

            migrationBuilder.CreateIndex(
                name: "fk_uf_pais",
                table: "uf",
                column: "id_pais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cidade");

            migrationBuilder.DropTable(
                name: "Logradouro");

            migrationBuilder.DropTable(
                name: "uf");

            migrationBuilder.DropTable(
                name: "TipoLogradouro");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
