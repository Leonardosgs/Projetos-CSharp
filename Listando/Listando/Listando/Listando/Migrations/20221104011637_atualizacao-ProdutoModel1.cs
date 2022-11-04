using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Listando.Migrations
{
    public partial class atualizacaoProdutoModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Usuarios_UsuarioId",
                table: "Listas");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Listas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produtos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listas_Usuarios_UsuarioId",
                table: "Listas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listas_Usuarios_UsuarioId",
                table: "Listas");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Produtos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Listas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "Itens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Listas_Usuarios_UsuarioId",
                table: "Listas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
