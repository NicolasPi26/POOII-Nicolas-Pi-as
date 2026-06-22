using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mecanicas_Tarea_6.Migrations
{
    /// <inheritdoc />
    public partial class vehiculosDATA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "correo",
                table: "Clientes",
                newName: "vehiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vehiculo",
                table: "Clientes",
                newName: "correo");
        }
    }
}
