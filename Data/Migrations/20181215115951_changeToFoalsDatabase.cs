using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class changeToFoalsDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Foals",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Foals",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
