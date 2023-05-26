using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjusteEtapa01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Pessoa_PessoaProprietariaResponsavelId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Pessoa_PessoaTerceiraID",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_TipoEtapa_TipoEtapaId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_FluxoProcesso_TipoEtapa_TipoEtapaId",
                table: "FluxoProcesso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso");

            migrationBuilder.DropIndex(
                name: "IX_FluxoProcesso_TipoEtapaId",
                table: "FluxoProcesso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_PessoaProprietariaResponsavelId",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_PessoaTerceiraID",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_TipoEtapaId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "Sequencia",
                table: "FluxoProcesso");

            migrationBuilder.DropColumn(
                name: "TipoEtapaId",
                table: "FluxoProcesso");

            migrationBuilder.DropColumn(
                name: "PessoaProprietariaResponsavelId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "PessoaTerceiraID",
                table: "Etapa");

            migrationBuilder.RenameColumn(
                name: "EtapaId",
                table: "Etapa",
                newName: "TipoProcessoId");

            migrationBuilder.RenameColumn(
                name: "TipoEtapaId",
                table: "Etapa",
                newName: "FluxoProcessoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso",
                columns: new[] { "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa",
                columns: new[] { "ProcessoId", "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_FluxoProcessoId_TipoProcessoId",
                table: "Etapa",
                columns: new[] { "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_TipoProcessoId",
                table: "Etapa",
                column: "TipoProcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_FluxoProcesso_FluxoProcessoId_TipoProcessoId",
                table: "Etapa",
                columns: new[] { "FluxoProcessoId", "TipoProcessoId" },
                principalTable: "FluxoProcesso",
                principalColumns: new[] { "FluxoProcessoId", "TipoProcessoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_TipoProcesso_TipoProcessoId",
                table: "Etapa",
                column: "TipoProcessoId",
                principalTable: "TipoProcesso",
                principalColumn: "TipoProcessoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_FluxoProcesso_FluxoProcessoId_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_TipoProcesso_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_FluxoProcessoId_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_TipoProcessoId",
                table: "Etapa");

            migrationBuilder.RenameColumn(
                name: "TipoProcessoId",
                table: "Etapa",
                newName: "EtapaId");

            migrationBuilder.RenameColumn(
                name: "FluxoProcessoId",
                table: "Etapa",
                newName: "TipoEtapaId");

            migrationBuilder.AddColumn<int>(
                name: "Sequencia",
                table: "FluxoProcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoEtapaId",
                table: "FluxoProcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "PessoaProprietariaResponsavelId",
                table: "Etapa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PessoaTerceiraID",
                table: "Etapa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluxoProcesso",
                table: "FluxoProcesso",
                column: "FluxoProcessoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa",
                columns: new[] { "ProcessoId", "TipoEtapaId" });

            migrationBuilder.CreateIndex(
                name: "IX_FluxoProcesso_TipoEtapaId",
                table: "FluxoProcesso",
                column: "TipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PessoaProprietariaResponsavelId",
                table: "Etapa",
                column: "PessoaProprietariaResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PessoaTerceiraID",
                table: "Etapa",
                column: "PessoaTerceiraID");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_TipoEtapaId",
                table: "Etapa",
                column: "TipoEtapaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Pessoa_PessoaProprietariaResponsavelId",
                table: "Etapa",
                column: "PessoaProprietariaResponsavelId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Pessoa_PessoaTerceiraID",
                table: "Etapa",
                column: "PessoaTerceiraID",
                principalTable: "Pessoa",
                principalColumn: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_TipoEtapa_TipoEtapaId",
                table: "Etapa",
                column: "TipoEtapaId",
                principalTable: "TipoEtapa",
                principalColumn: "TipoEtapaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluxoProcesso_TipoEtapa_TipoEtapaId",
                table: "FluxoProcesso",
                column: "TipoEtapaId",
                principalTable: "TipoEtapa",
                principalColumn: "TipoEtapaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
