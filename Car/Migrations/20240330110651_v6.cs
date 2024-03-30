using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cars",
                newName: "BodyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Bodies",
                newName: "BodyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BodyName",
                table: "Cars",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BodyName",
                table: "Bodies",
                newName: "Name");
        }
    }
}
