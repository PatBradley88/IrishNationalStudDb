using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addStallionsIdMigToMares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stallions_Mares_MaresId",
                table: "Stallions");

            migrationBuilder.DropIndex(
                name: "IX_Stallions_MaresId",
                table: "Stallions");

            migrationBuilder.DropColumn(
                name: "MaresId",
                table: "Stallions");

            migrationBuilder.DropColumn(
                name: "Stallion",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "MaresId",
                table: "Stallions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stallion",
                table: "Mares",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stallions_MaresId",
                table: "Stallions",
                column: "MaresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stallions_Mares_MaresId",
                table: "Stallions",
                column: "MaresId",
                principalTable: "Mares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
