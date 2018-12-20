using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addFoalsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mares_Stallions_StallionId",
                table: "Mares");

            migrationBuilder.DropForeignKey(
                name: "FK_Mares_Stallions_StallionsId",
                table: "Mares");

            migrationBuilder.DropIndex(
                name: "IX_Mares_StallionId",
                table: "Mares");

            migrationBuilder.DropIndex(
                name: "IX_Mares_StallionsId",
                table: "Mares");

            migrationBuilder.DropColumn(
                name: "StallionId",
                table: "Mares");

            migrationBuilder.DropColumn(
                name: "StallionsId",
                table: "Mares");

            migrationBuilder.RenameColumn(
                name: "Foal",
                table: "Mares",
                newName: "Stallion");

            migrationBuilder.AddColumn<int>(
                name: "MaresId",
                table: "Stallions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Foals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DOB = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Colour = table.Column<string>(nullable: false),
                    Sire = table.Column<string>(nullable: true),
                    Dam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foals", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stallions_Mares_MaresId",
                table: "Stallions");

            migrationBuilder.DropTable(
                name: "Foals");

            migrationBuilder.DropIndex(
                name: "IX_Stallions_MaresId",
                table: "Stallions");

            migrationBuilder.DropColumn(
                name: "MaresId",
                table: "Stallions");

            migrationBuilder.RenameColumn(
                name: "Stallion",
                table: "Mares",
                newName: "Foal");

            migrationBuilder.AddColumn<int>(
                name: "StallionId",
                table: "Mares",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StallionsId",
                table: "Mares",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mares_StallionId",
                table: "Mares",
                column: "StallionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mares_StallionsId",
                table: "Mares",
                column: "StallionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mares_Stallions_StallionId",
                table: "Mares",
                column: "StallionId",
                principalTable: "Stallions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mares_Stallions_StallionsId",
                table: "Mares",
                column: "StallionsId",
                principalTable: "Stallions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
