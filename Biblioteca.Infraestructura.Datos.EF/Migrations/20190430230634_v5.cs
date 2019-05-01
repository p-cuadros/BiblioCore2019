using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Infraestructura.Datos.EF.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "NUM_PAGINAS",
                table: "LIBROS",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "LIBROS",
                type: "VARCHAR(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<short>(
                name: "ID_EDITORIAL",
                table: "LIBROS",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NUM_PAGINAS",
                table: "LIBROS",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "LIBROS",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(25)");

            migrationBuilder.AlterColumn<int>(
                name: "ID_EDITORIAL",
                table: "LIBROS",
                nullable: false,
                oldClrType: typeof(short));
        }
    }
}
