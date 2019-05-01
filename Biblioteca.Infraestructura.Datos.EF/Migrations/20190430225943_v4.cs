using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Infraestructura.Datos.EF.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_Libros_IDLibro",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_LibroAutores_Libros_IDLibro",
                table: "LibroAutores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Libros",
                table: "Libros");

            migrationBuilder.RenameTable(
                name: "Libros",
                newName: "LIBROS");

            migrationBuilder.RenameColumn(
                name: "TituloLibro",
                table: "LIBROS",
                newName: "TITULO");

            migrationBuilder.RenameColumn(
                name: "NumeroPaginas",
                table: "LIBROS",
                newName: "NUM_PAGINAS");

            migrationBuilder.RenameColumn(
                name: "IDEditorial",
                table: "LIBROS",
                newName: "ID_EDITORIAL");

            migrationBuilder.RenameColumn(
                name: "IDLibro",
                table: "LIBROS",
                newName: "ID_LIBRO");

            migrationBuilder.RenameColumn(
                name: "TipoLibro",
                table: "LIBROS",
                newName: "ID_TIPO_LIBRO");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "LIBROS",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TITULO",
                table: "LIBROS",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LIBROS",
                table: "LIBROS",
                column: "ID_LIBRO");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_LIBROS_IDLibro",
                table: "Ejemplares",
                column: "IDLibro",
                principalTable: "LIBROS",
                principalColumn: "ID_LIBRO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LibroAutores_LIBROS_IDLibro",
                table: "LibroAutores",
                column: "IDLibro",
                principalTable: "LIBROS",
                principalColumn: "ID_LIBRO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_LIBROS_IDLibro",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_LibroAutores_LIBROS_IDLibro",
                table: "LibroAutores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LIBROS",
                table: "LIBROS");

            migrationBuilder.RenameTable(
                name: "LIBROS",
                newName: "Libros");

            migrationBuilder.RenameColumn(
                name: "TITULO",
                table: "Libros",
                newName: "TituloLibro");

            migrationBuilder.RenameColumn(
                name: "NUM_PAGINAS",
                table: "Libros",
                newName: "NumeroPaginas");

            migrationBuilder.RenameColumn(
                name: "ID_EDITORIAL",
                table: "Libros",
                newName: "IDEditorial");

            migrationBuilder.RenameColumn(
                name: "ID_LIBRO",
                table: "Libros",
                newName: "IDLibro");

            migrationBuilder.RenameColumn(
                name: "ID_TIPO_LIBRO",
                table: "Libros",
                newName: "TipoLibro");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Libros",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "TituloLibro",
                table: "Libros",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Libros",
                table: "Libros",
                column: "IDLibro");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_Libros_IDLibro",
                table: "Ejemplares",
                column: "IDLibro",
                principalTable: "Libros",
                principalColumn: "IDLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LibroAutores_Libros_IDLibro",
                table: "LibroAutores",
                column: "IDLibro",
                principalTable: "Libros",
                principalColumn: "IDLibro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
