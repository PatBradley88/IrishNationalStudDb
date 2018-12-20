using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addToFoalsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Colour", "DOB", "Dam", "Sire" },
                values: new object[] { "Bay", new DateTime(2017, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alava", "Dragon Pulse" });

            migrationBuilder.InsertData(
                table: "Foals",
                columns: new[] { "Id", "Colour", "DOB", "Dam", "Name", "Sex", "Sire" },
                values: new object[,]
                {
                    { 2, "Bay", new DateTime(2017, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bayja", " ", 0, "Invincible Spirit" },
                    { 3, "Bay", new DateTime(2017, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bound Copy", " ", 0, "National Defense" },
                    { 4, "Bay", new DateTime(2017, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cascading", " ", 0, "Elusive Pimpernel" },
                    { 5, "Grey", new DateTime(2017, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Follow My Lead", " ", 0, "Decorated Knight" },
                    { 6, "Chestnut", new DateTime(2017, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diamond Sky", " ", 0, "Gale Force Ten" },
                    { 7, "Brown", new DateTime(2017, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dazzle Dancer", " ", 0, "Free Eagle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Colour", "DOB", "Dam", "Sire" },
                values: new object[] { "Chestnut", new DateTime(2017, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diamond Sky", "Gale Force Ten" });
        }
    }
}
