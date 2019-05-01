using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Infraestructura.Datos.EF.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibroAutores_Autores_IDAutor",
                table: "LibroAutores");

            migrationBuilder.DropForeignKey(
                name: "FK_LibroAutores_LIBROS_IDLibro",
                table: "LibroAutores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autores",
                table: "Autores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibroAutores",
                table: "LibroAutores");

            migrationBuilder.RenameTable(
                name: "Autores",
                newName: "AUTORES");

            migrationBuilder.RenameTable(
                name: "LibroAutores",
                newName: "LIBRO_AUTORES");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "AUTORES",
                newName: "NOM_AUTOR");

            migrationBuilder.RenameColumn(
                name: "IDAutor",
                table: "AUTORES",
                newName: "ID_AUTOR");

            migrationBuilder.RenameColumn(
                name: "IDAutor",
                table: "LIBRO_AUTORES",
                newName: "ID_AUTOR");

            migrationBuilder.RenameColumn(
                name: "IDLibro",
                table: "LIBRO_AUTORES",
                newName: "ID_LIBRO");

            migrationBuilder.RenameIndex(
                name: "IX_LibroAutores_IDAutor",
                table: "LIBRO_AUTORES",
                newName: "IX_LIBRO_AUTORES_ID_AUTOR");

            migrationBuilder.AlterColumn<string>(
                name: "TITULO",
                table: "LIBROS",
                type: "VARCHAR(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_AUTOR",
                table: "AUTORES",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AUTORES",
                table: "AUTORES",
                column: "ID_AUTOR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LIBRO_AUTORES",
                table: "LIBRO_AUTORES",
                columns: new[] { "ID_LIBRO", "ID_AUTOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_LIBRO_AUTORES_AUTORES_ID_AUTOR",
                table: "LIBRO_AUTORES",
                column: "ID_AUTOR",
                principalTable: "AUTORES",
                principalColumn: "ID_AUTOR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LIBRO_AUTORES_LIBROS_ID_LIBRO",
                table: "LIBRO_AUTORES",
                column: "ID_LIBRO",
                principalTable: "LIBROS",
                principalColumn: "ID_LIBRO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LIBRO_AUTORES_AUTORES_ID_AUTOR",
                table: "LIBRO_AUTORES");

            migrationBuilder.DropForeignKey(
                name: "FK_LIBRO_AUTORES_LIBROS_ID_LIBRO",
                table: "LIBRO_AUTORES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AUTORES",
                table: "AUTORES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LIBRO_AUTORES",
                table: "LIBRO_AUTORES");

            migrationBuilder.RenameTable(
                name: "AUTORES",
                newName: "Autores");

            migrationBuilder.RenameTable(
                name: "LIBRO_AUTORES",
                newName: "LibroAutores");

            migrationBuilder.RenameColumn(
                name: "NOM_AUTOR",
                table: "Autores",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "ID_AUTOR",
                table: "Autores",
                newName: "IDAutor");

            migrationBuilder.RenameColumn(
                name: "ID_AUTOR",
                table: "LibroAutores",
                newName: "IDAutor");

            migrationBuilder.RenameColumn(
                name: "ID_LIBRO",
                table: "LibroAutores",
                newName: "IDLibro");

            migrationBuilder.RenameIndex(
                name: "IX_LIBRO_AUTORES_ID_AUTOR",
                table: "LibroAutores",
                newName: "IX_LibroAutores_IDAutor");

            migrationBuilder.AlterColumn<string>(
                name: "TITULO",
                table: "LIBROS",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Autores",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autores",
                table: "Autores",
                column: "IDAutor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibroAutores",
                table: "LibroAutores",
                columns: new[] { "IDLibro", "IDAutor" });

            migrationBuilder.AddForeignKey(
                name: "FK_LibroAutores_Autores_IDAutor",
                table: "LibroAutores",
                column: "IDAutor",
                principalTable: "Autores",
                principalColumn: "IDAutor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LibroAutores_LIBROS_IDLibro",
                table: "LibroAutores",
                column: "IDLibro",
                principalTable: "LIBROS",
                principalColumn: "ID_LIBRO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
