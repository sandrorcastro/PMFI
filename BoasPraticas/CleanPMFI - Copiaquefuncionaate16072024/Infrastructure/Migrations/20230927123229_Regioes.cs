using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Regioes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<long>(type: "bigint", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    IdRegiao = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CidadeId = table.Column<int>(type: "int", nullable: true),
                    PercentualUvc = table.Column<decimal>(type: "money", nullable: true),
                    CentroGrauLon = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CentroGrauLat = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.IdRegiao);
                    table.ForeignKey(
                        name: "FK_Regiao_cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "cidade",
                        principalColumn: "id_cidade");
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    IdDocumento = table.Column<long>(type: "bigint", nullable: false),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPessoa = table.Column<long>(type: "bigint", nullable: false),
                    PessoaIdPessoa = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.IdDocumento);
                    table.ForeignKey(
                        name: "FK_Documento_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntidadeEndereco",
                columns: table => new
                {
                    IdEntidadeEndereco = table.Column<long>(type: "bigint", nullable: false),
                    IdEndereco = table.Column<long>(type: "bigint", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PessoaIdPessoa = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadeEndereco", x => x.IdEntidadeEndereco);
                    table.ForeignKey(
                        name: "FK_EntidadeEndereco_Pessoa_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa");
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<long>(type: "bigint", nullable: false),
                    IdLogradouro = table.Column<int>(type: "int", nullable: false),
                    LogradouroIdLogradouro = table.Column<int>(type: "int", nullable: false),
                    IdCidade = table.Column<int>(type: "int", nullable: true),
                    CidadeIdCidade = table.Column<int>(type: "int", nullable: false),
                    IdPais = table.Column<int>(type: "int", nullable: true),
                    PaisIdPais = table.Column<int>(type: "int", nullable: false),
                    IdUf = table.Column<int>(type: "int", nullable: true),
                    UfIdUf = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Referencia = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Correspondencia = table.Column<bool>(type: "bit", nullable: true),
                    EntidadeEnderecoIdEntidadeEndereco = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_cidade_CidadeIdCidade",
                        column: x => x.CidadeIdCidade,
                        principalTable: "cidade",
                        principalColumn: "id_cidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_EntidadeEndereco_EntidadeEnderecoIdEntidadeEndereco",
                        column: x => x.EntidadeEnderecoIdEntidadeEndereco,
                        principalTable: "EntidadeEndereco",
                        principalColumn: "IdEntidadeEndereco");
                    table.ForeignKey(
                        name: "FK_Endereco_Logradouro_LogradouroIdLogradouro",
                        column: x => x.LogradouroIdLogradouro,
                        principalTable: "Logradouro",
                        principalColumn: "IdLogradouro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_pais_PaisIdPais",
                        column: x => x.PaisIdPais,
                        principalTable: "pais",
                        principalColumn: "id_pais",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_uf_UfIdUf",
                        column: x => x.UfIdUf,
                        principalTable: "uf",
                        principalColumn: "id_uf",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documento_PessoaIdPessoa",
                table: "Documento",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CidadeIdCidade",
                table: "Endereco",
                column: "CidadeIdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EntidadeEnderecoIdEntidadeEndereco",
                table: "Endereco",
                column: "EntidadeEnderecoIdEntidadeEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_LogradouroIdLogradouro",
                table: "Endereco",
                column: "LogradouroIdLogradouro");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PaisIdPais",
                table: "Endereco",
                column: "PaisIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_UfIdUf",
                table: "Endereco",
                column: "UfIdUf");

            migrationBuilder.CreateIndex(
                name: "IX_EntidadeEndereco_PessoaIdPessoa",
                table: "EntidadeEndereco",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Regiao_CidadeId",
                table: "Regiao",
                column: "CidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Regiao");

            migrationBuilder.DropTable(
                name: "EntidadeEndereco");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
