using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMuseo.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exposiciones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exposiciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    es_persona = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ObrasCine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    directorId = table.Column<int>(type: "int", nullable: true),
                    escritorId = table.Column<int>(type: "int", nullable: true),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObrasCine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObrasCine_Personas_directorId",
                        column: x => x.directorId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ObrasCine_Personas_escritorId",
                        column: x => x.escritorId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObrasPintura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PintorId = table.Column<int>(type: "int", nullable: true),
                    tecnica = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObrasPintura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObrasPintura_Personas_PintorId",
                        column: x => x.PintorId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    exposicionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    obraCineId = table.Column<int>(type: "int", nullable: true),
                    obraPinturaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obras_Exposiciones_exposicionId",
                        column: x => x.exposicionId,
                        principalTable: "Exposiciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Obras_ObrasCine_obraCineId",
                        column: x => x.obraCineId,
                        principalTable: "ObrasCine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Obras_ObrasPintura_obraPinturaId",
                        column: x => x.obraPinturaId,
                        principalTable: "ObrasPintura",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObraSala",
                columns: table => new
                {
                    ObrasId = table.Column<int>(type: "int", nullable: false),
                    Salasid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObraSala", x => new { x.ObrasId, x.Salasid });
                    table.ForeignKey(
                        name: "FK_ObraSala_Obras_ObrasId",
                        column: x => x.ObrasId,
                        principalTable: "Obras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObraSala_Salas_Salasid",
                        column: x => x.Salasid,
                        principalTable: "Salas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Obras_exposicionId",
                table: "Obras",
                column: "exposicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Obras_obraCineId",
                table: "Obras",
                column: "obraCineId");

            migrationBuilder.CreateIndex(
                name: "IX_Obras_obraPinturaId",
                table: "Obras",
                column: "obraPinturaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObraSala_Salasid",
                table: "ObraSala",
                column: "Salasid");

            migrationBuilder.CreateIndex(
                name: "IX_ObrasCine_directorId",
                table: "ObrasCine",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_ObrasCine_escritorId",
                table: "ObrasCine",
                column: "escritorId");

            migrationBuilder.CreateIndex(
                name: "IX_ObrasPintura_PintorId",
                table: "ObrasPintura",
                column: "PintorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObraSala");

            migrationBuilder.DropTable(
                name: "Obras");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "Exposiciones");

            migrationBuilder.DropTable(
                name: "ObrasCine");

            migrationBuilder.DropTable(
                name: "ObrasPintura");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
