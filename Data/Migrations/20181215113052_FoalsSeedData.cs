using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class FoalsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foals",
                columns: new[] { "Id", "Colour", "DOB", "Dam", "Name", "Sex", "Sire" },
                values: new object[] { 1, "Chestnut", new DateTime(2017, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diamond Sky", " ", 0, "Gale Force Ten" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
