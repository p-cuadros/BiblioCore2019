using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Infraestructura.Datos.EF.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDEditorial",
                table: "Libros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroPaginas",
                table: "Libros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "TipoLibro",
                table: "Libros",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDEditorial",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "NumeroPaginas",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "TipoLibro",
                table: "Libros");
        }
    }
}
