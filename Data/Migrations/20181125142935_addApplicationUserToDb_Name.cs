using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addApplicationUserToDb_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stallions_Mares_MaresIdId",
                table: "Stallions");

            migrationBuilder.DropIndex(
                name: "IX_Stallions_MaresIdId",
                table: "Stallions");

            migrationBuilder.DropColumn(
                name: "MaresIdId",
                table: "Stallions");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "MaresIdId",
                table: "Stallions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stallions_MaresIdId",
                table: "Stallions",
                column: "MaresIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stallions_Mares_MaresIdId",
                table: "Stallions",
                column: "MaresIdId",
                principalTable: "Mares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
