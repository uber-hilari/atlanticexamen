using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atlantic.Examen.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DbInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dirección = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubigeo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnListaNegra = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoEn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificadoEn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoEn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioAlquiler = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    CodigoQR = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CantidadCopias = table.Column<int>(type: "int", nullable: false),
                    CopiasDisponibles = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoEn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificadoEn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoEn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLibro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaAlquiler = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRetorno = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    EstadoLibro = table.Column<int>(type: "int", nullable: false),
                    EstadoAlquiler = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoEn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificadoEn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EliminadoEn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alquiler_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Libro_IdLibro",
                        column: x => x.IdLibro,
                        principalTable: "Libro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_IdCliente",
                table: "Alquiler",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_IdLibro",
                table: "Alquiler",
                column: "IdLibro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquiler");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Libro");
        }
    }
}
