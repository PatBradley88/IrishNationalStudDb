using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrishNationalStud.Data.Migrations
{
    public partial class addMaresToSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dam", "Name" },
                values: new object[] { "Dansky", "" });

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "");

            migrationBuilder.InsertData(
                table: "Mares",
                columns: new[] { "Id", "Colour", "DOB", "Dam", "DueDate", "Foal", "InFoal", "Name", "Sire", "Stallions" },
                values: new object[,]
                {
                    { 1, "Bay", new DateTime(2006, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cerita", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Alava", "Anabaa", "Invincible Spirit" },
                    { 2, "Bay", new DateTime(2009, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Revenue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Bayja", "Galileo", "Free Eagle" },
                    { 3, "Bay", new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our Tristalight", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Dansky", "Danehill", "Galileo" },
                    { 4, "Bay", new DateTime(2011, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angel Falls", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Cascading", "Teofilo", "Australia" },
                    { 5, "Grey", new DateTime(2008, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pompeii", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Follow My Lead", "Stratum", "Sea The Stars" },
                    { 6, "Chestnut", new DateTime(2010, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danaskaya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Diamond Sky", "Montjeu", "Dragon Pulse" },
                    { 7, "Brown", new DateTime(2006, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Another Dancer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Dazzle Dancer", "Montjeu", "Decorated Knight" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mares",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mares",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mares",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mares",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mares",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mares",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mares",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dam", "Name" },
                values: new object[] { "Bound Copy", " " });

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Foals",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: " ");
        }
    }
}
