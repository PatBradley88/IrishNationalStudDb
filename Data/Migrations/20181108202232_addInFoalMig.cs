using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addInFoalMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stallion",
                table: "Mares",
                newName: "Stallions");

            migrationBuilder.AddColumn<bool>(
                name: "InFoal",
                table: "Mares",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InFoal",
                table: "Mares");

            migrationBuilder.RenameColumn(
                name: "Stallions",
                table: "Mares",
                newName: "Stallion");
        }
    }
}
