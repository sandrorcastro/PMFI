using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjusteEndereco_Entidade01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Economia_Entidade_Economia_ImovelId_EconomiaId",
                table: "Economia_Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Entidade_Economia_EconomiaImovelId_EconomiaId",
                table: "Endereco_Entidade");

            migrationBuilder.DropTable(
                name: "EconomiaEndereco");

            migrationBuilder.DropTable(
                name: "EnderecoPessoa");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_Entidade_EconomiaImovelId_EconomiaId",
                table: "Endereco_Entidade");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_Entidade_ImovelId",
                table: "Endereco_Entidade");

            migrationBuilder.DropColumn(
                name: "EconomiaImovelId",
                table: "Endereco_Entidade");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Entidade_ImovelId_EconomiaId",
                table: "Endereco_Entidade",
                columns: new[] { "ImovelId", "EconomiaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Economia_Entidade_Economia_ImovelId_EconomiaId",
                table: "Economia_Entidade",
                columns: new[] { "ImovelId", "EconomiaId" },
                principalTable: "Economia",
                principalColumns: new[] { "ImovelId", "EconomiaId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Entidade_Economia_ImovelId_EconomiaId",
                table: "Endereco_Entidade",
                columns: new[] { "ImovelId", "EconomiaId" },
                principalTable: "Economia",
                principalColumns: new[] { "ImovelId", "EconomiaId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Economia_Entidade_Economia_ImovelId_EconomiaId",
                table: "Economia_Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Entidade_Economia_ImovelId_EconomiaId",
                table: "Endereco_Entidade");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_Entidade_ImovelId_EconomiaId",
                table: "Endereco_Entidade");

            migrationBuilder.AddColumn<long>(
                name: "EconomiaImovelId",
                table: "Endereco_Entidade",
                type: "bigint",
                nullable: true);

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
                name: "IX_Endereco_Entidade_EconomiaImovelId_EconomiaId",
                table: "Endereco_Entidade",
                columns: new[] { "EconomiaImovelId", "EconomiaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Entidade_ImovelId",
                table: "Endereco_Entidade",
                column: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomiaEndereco_EconomiasImovelId_EconomiasEconomiaId",
                table: "EconomiaEndereco",
                columns: new[] { "EconomiasImovelId", "EconomiasEconomiaId" });

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoPessoa_PessoasPessoaId",
                table: "EnderecoPessoa",
                column: "PessoasPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Economia_Entidade_Economia_ImovelId_EconomiaId",
                table: "Economia_Entidade",
                columns: new[] { "ImovelId", "EconomiaId" },
                principalTable: "Economia",
                principalColumns: new[] { "ImovelId", "EconomiaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Entidade_Economia_EconomiaImovelId_EconomiaId",
                table: "Endereco_Entidade",
                columns: new[] { "EconomiaImovelId", "EconomiaId" },
                principalTable: "Economia",
                principalColumns: new[] { "ImovelId", "EconomiaId" });
        }
    }
}
