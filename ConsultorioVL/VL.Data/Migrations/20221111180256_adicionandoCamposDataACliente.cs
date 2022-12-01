using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VL.Data.Migrations
{
    public partial class adicionandoCamposDataACliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Clientes",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "UltimaAtualizacao",
                table: "Clientes");
        }
    }
}
