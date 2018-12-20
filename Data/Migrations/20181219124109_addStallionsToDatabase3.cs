using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addStallionsToDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stallions",
                columns: new[] { "Id", "Colour", "DOB", "Dam", "Image", "Name", "Sire" },
                values: new object[,]
                {
                    { 1, "Bay", new DateTime(1997, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rafha (Kris)", null, "Invincible Spirit", "Green Dessert" },
                    { 2, "Bay", new DateTime(2014, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angel Falls (Kingmambo)", null, "National Defense", "Invincible Spirit" },
                    { 3, "Bay", new DateTime(2011, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polished Gem (Danehill)", null, "Free Eagle", "High Chaparral" },
                    { 4, "Chestnut", new DateTime(2014, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poetical (Croco Rouge)", null, "Dragon Pulse", "Kyllachy" },
                    { 5, "Brown", new DateTime(2007, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cara Fantasy (Sadler's Wells)", null, "Elusive Pimpernel", "Elusive Quality" },
                    { 6, "Bay", new DateTime(2009, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pearling (Storm Cat)", null, "Decorated Knight", "Galileo" },
                    { 7, "Bay", new DateTime(2010, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ronaldsay (Kirkwall)", null, "Gale Force Ten", "Oasis Dream" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stallions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stallions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stallions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stallions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stallions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stallions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stallions",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
