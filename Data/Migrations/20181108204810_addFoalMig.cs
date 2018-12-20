using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addFoalMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stallions",
                table: "Mares",
                newName: "Stallion");

            migrationBuilder.AddColumn<string>(
                name: "Foal",
                table: "Mares",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foal",
                table: "Mares");

            migrationBuilder.RenameColumn(
                name: "Stallion",
                table: "Mares",
                newName: "Stallions");
        }
    }
}
