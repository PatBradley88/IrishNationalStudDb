using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addStallionsMigToMares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mares_Stallions_StallionsId",
                table: "Mares");

            migrationBuilder.DropIndex(
                name: "IX_Mares_StallionsId",
                table: "Mares");

            migrationBuilder.DropColumn(
                name: "StallionsId",
                table: "Mares");

            migrationBuilder.AddColumn<int>(
                name: "MaresIdId",
                table: "Stallions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stallions",
                table: "Mares",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Stallions",
                table: "Mares");

            migrationBuilder.AddColumn<int>(
                name: "StallionsId",
                table: "Mares",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Mares_StallionsId",
                table: "Mares",
                column: "StallionsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mares_Stallions_StallionsId",
                table: "Mares",
                column: "StallionsId",
                principalTable: "Stallions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
