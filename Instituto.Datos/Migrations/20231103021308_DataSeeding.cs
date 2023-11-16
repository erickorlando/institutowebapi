using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Instituto.Datos.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Alumno",
                columns: new[] { "Id", "Correo", "Edad", "Estado", "Nombre" },
                values: new object[,]
                {
                    { 1, "pepe@gmail.com", 10, true, "Pepe" },
                    { 2, "juan@gmail.com", 10, true, "Juan" },
                    { 3, "pedro@gmail.com", 10, true, "Pedro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Alumno",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Alumno",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Alumno",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
