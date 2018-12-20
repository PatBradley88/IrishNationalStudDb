using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addStallionMigToMares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stallion",
                table: "Mares");

            migrationBuilder.AddColumn<int>(
                name: "StallionId",
                table: "Mares",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mares_StallionId",
                table: "Mares",
                column: "StallionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mares_Stallions_StallionId",
                table: "Mares",
                column: "StallionId",
                principalTable: "Stallions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mares_Stallions_StallionId",
                table: "Mares");

            migrationBuilder.DropIndex(
                name: "IX_Mares_StallionId",
                table: "Mares");

            migrationBuilder.DropColumn(
                name: "StallionId",
                table: "Mares");

            migrationBuilder.AddColumn<string>(
                name: "Stallion",
                table: "Mares",
                nullable: true);
        }
    }
}
