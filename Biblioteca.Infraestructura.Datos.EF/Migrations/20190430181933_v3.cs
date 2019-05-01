using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Infraestructura.Datos.EF.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    IDAutor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.IDAutor);
                });

            migrationBuilder.CreateTable(
                name: "Ejemplares",
                columns: table => new
                {
                    IDEjemplar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDLibro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplares", x => x.IDEjemplar);
                    table.ForeignKey(
                        name: "FK_Ejemplares_Libros_IDLibro",
                        column: x => x.IDLibro,
                        principalTable: "Libros",
                        principalColumn: "IDLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IDUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IDUsuario);
                });

            migrationBuilder.CreateTable(
                name: "LibroAutores",
                columns: table => new
                {
                    IDLibro = table.Column<int>(nullable: false),
                    IDAutor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroAutores", x => new { x.IDLibro, x.IDAutor });
                    table.ForeignKey(
                        name: "FK_LibroAutores_Autores_IDAutor",
                        column: x => x.IDAutor,
                        principalTable: "Autores",
                        principalColumn: "IDAutor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibroAutores_Libros_IDLibro",
                        column: x => x.IDLibro,
                        principalTable: "Libros",
                        principalColumn: "IDLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    IDPrestamo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDEjemplar = table.Column<int>(nullable: false),
                    IDUsuario = table.Column<int>(nullable: false),
                    FechaPrestamo = table.Column<DateTime>(nullable: false),
                    FechaDevolucion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.IDPrestamo);
                    table.ForeignKey(
                        name: "FK_Prestamos_Ejemplares_IDEjemplar",
                        column: x => x.IDEjemplar,
                        principalTable: "Ejemplares",
                        principalColumn: "IDEjemplar",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Usuarios_IDUsuario",
                        column: x => x.IDUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IDUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_IDLibro",
                table: "Ejemplares",
                column: "IDLibro");

            migrationBuilder.CreateIndex(
                name: "IX_LibroAutores_IDAutor",
                table: "LibroAutores",
                column: "IDAutor");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_IDEjemplar",
                table: "Prestamos",
                column: "IDEjemplar");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_IDUsuario",
                table: "Prestamos",
                column: "IDUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroAutores");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Ejemplares");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
