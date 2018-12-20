using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addStallionsMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StallionsId",
                table: "Mares",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mares_StallionsId",
                table: "Mares",
                column: "StallionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mares_Stallions_StallionsId",
                table: "Mares",
                column: "StallionsId",
                principalTable: "Stallions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
        }
    }
}
