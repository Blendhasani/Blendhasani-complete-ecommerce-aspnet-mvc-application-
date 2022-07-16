using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class NameFixCinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Cinemas",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "Decription",
                table: "Cinemas",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Cinemas",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Decription");
        }
    }
}
