using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Telefon_Kayit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modelismideğiştirme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Phones",
                newName: "Modelo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Phones",
                newName: "Model");
        }
    }
}
