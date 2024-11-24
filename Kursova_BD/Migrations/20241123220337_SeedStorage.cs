using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kursova_BD.Migrations
{
    /// <inheritdoc />
    public partial class SeedStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "ItemId", "Quantity", "UpdateTime" },
                values: new object[,]
                {
                    { 1, 1, 80, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 2, 2, 75, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 3, 3, 90, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 4, 4, 85, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 5, 5, 95, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 6, 6, 60, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 7, 7, 70, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 8, 8, 65, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 9, 9, 75, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 10, 10, 80, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 11, 11, 55, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 12, 12, 70, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 13, 13, 85, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 14, 14, 90, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 15, 15, 95, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 16, 16, 75, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 17, 17, 80, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 18, 18, 85, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 19, 19, 90, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 20, 20, 95, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 21, 21, 60, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 22, 22, 70, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 23, 23, 75, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 24, 24, 80, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 25, 25, 85, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 26, 26, 80, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 27, 27, 85, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 28, 28, 90, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 29, 29, 95, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 30, 30, 100, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 31, 31, 100, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 32, 32, 95, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 33, 33, 90, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 34, 34, 85, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) },
                    { 35, 35, 80, new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
