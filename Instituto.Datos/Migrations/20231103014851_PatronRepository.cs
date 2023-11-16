﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instituto.Datos.Migrations
{
    /// <inheritdoc />
    public partial class PatronRepository : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Alumno",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Alumno");
        }
    }
}
