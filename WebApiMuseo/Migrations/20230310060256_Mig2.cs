using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMuseo.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras");

            migrationBuilder.AlterColumn<int>(
                name: "ExposicionId",
                table: "Obras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras",
                column: "ExposicionId",
                principalTable: "Exposiciones",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras");

            migrationBuilder.AlterColumn<int>(
                name: "ExposicionId",
                table: "Obras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_Exposiciones_ExposicionId",
                table: "Obras",
                column: "ExposicionId",
                principalTable: "Exposiciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
