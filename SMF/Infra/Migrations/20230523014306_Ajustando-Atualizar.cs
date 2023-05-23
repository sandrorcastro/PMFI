using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjustandoAtualizar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EconomiaEndereco",
                columns: table => new
                {
                    Enderecos_EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    EconomiasImovelId = table.Column<long>(type: "bigint", nullable: false),
                    EconomiasEconomiaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomiaEndereco", x => new { x.Enderecos_EnderecoId, x.EconomiasImovelId, x.EconomiasEconomiaId });
                    table.ForeignKey(
                        name: "FK_EconomiaEndereco_Economia_EconomiasImovelId_EconomiasEconomiaId",
                        columns: x => new { x.EconomiasImovelId, x.EconomiasEconomiaId },
                        principalTable: "Economia",
                        principalColumns: new[] { "ImovelId", "EconomiaId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EconomiaEndereco_Endereco_Enderecos_EnderecoId",
                        column: x => x.Enderecos_EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoPessoa",
                columns: table => new
                {
                    Enderecos_EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    PessoasPessoaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoPessoa", x => new { x.Enderecos_EnderecoId, x.PessoasPessoaId });
                    table.ForeignKey(
                        name: "FK_EnderecoPessoa_Endereco_Enderecos_EnderecoId",
                        column: x => x.Enderecos_EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnderecoPessoa_Pessoa_PessoasPessoaId",
                        column: x => x.PessoasPessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EconomiaEndereco_EconomiasImovelId_EconomiasEconomiaId",
                table: "EconomiaEndereco",
                columns: new[] { "EconomiasImovelId", "EconomiasEconomiaId" });

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoPessoa_PessoasPessoaId",
                table: "EnderecoPessoa",
                column: "PessoasPessoaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EconomiaEndereco");

            migrationBuilder.DropTable(
                name: "EnderecoPessoa");
        }
    }
}
