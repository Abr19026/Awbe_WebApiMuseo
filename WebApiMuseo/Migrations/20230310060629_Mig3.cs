using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMuseo.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras");

            migrationBuilder.DropForeignKey(
                name: "FK_Obras_ObrasCine_obraCineId",
                table: "Obras");

            migrationBuilder.DropForeignKey(
                name: "FK_Obras_ObrasPintura_obraPinturaId",
                table: "Obras");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Salas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "obraPinturaId",
                table: "Obras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "obraCineId",
                table: "Obras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ExposicionId",
                table: "Obras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Exposiciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Exposiciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras",
                column: "ExposicionId",
                principalTable: "Exposiciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_ObrasCine_obraCineId",
                table: "Obras",
                column: "obraCineId",
                principalTable: "ObrasCine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_ObrasPintura_obraPinturaId",
                table: "Obras",
                column: "obraPinturaId",
                principalTable: "ObrasPintura",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras");

            migrationBuilder.DropForeignKey(
                name: "FK_Obras_ObrasCine_obraCineId",
                table: "Obras");

            migrationBuilder.DropForeignKey(
                name: "FK_Obras_ObrasPintura_obraPinturaId",
                table: "Obras");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Exposiciones");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Salas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "obraPinturaId",
                table: "Obras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "obraCineId",
                table: "Obras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExposicionId",
                table: "Obras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Exposiciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras",
                column: "ExposicionId",
                principalTable: "Exposiciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_ObrasCine_obraCineId",
                table: "Obras",
                column: "obraCineId",
                principalTable: "ObrasCine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_ObrasPintura_obraPinturaId",
                table: "Obras",
                column: "obraPinturaId",
                principalTable: "ObrasPintura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
