﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Inicialajuste05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoObjetoProcesso",
                table: "ObjetoProcesso",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoObjetoProcesso",
                table: "ObjetoProcesso",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "Não Definido",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "ObjetoProcessoConfiguration");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoObjetoProcesso",
                table: "ObjetoProcesso",
                type: "int",
                nullable: false,
                defaultValue: 5,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoObjetoProcesso",
                table: "ObjetoProcesso",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "ObjetoProcessoConfiguration",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "Não Definido");
        }
    }
}
