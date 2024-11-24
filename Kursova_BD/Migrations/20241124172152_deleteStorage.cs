using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kursova_BD.Migrations
{
    /// <inheritdoc />
    public partial class deleteStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Storages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storages_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "ItemId", "Quantity", "UpdateTime" },
                values: new object[,]
                {
                    { 1, 1, 80, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 2, 2, 75, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 3, 3, 90, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 4, 4, 85, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 5, 5, 95, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 6, 6, 60, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 7, 7, 70, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 8, 8, 65, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 9, 9, 75, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 10, 10, 80, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 11, 11, 55, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 12, 12, 70, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 13, 13, 85, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 14, 14, 90, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 15, 15, 95, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 16, 16, 75, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 17, 17, 80, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 18, 18, 85, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 19, 19, 90, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 20, 20, 95, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 21, 21, 60, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 22, 22, 70, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 23, 23, 75, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 24, 24, 80, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 25, 25, 85, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 26, 26, 80, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 27, 27, 85, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 28, 28, 90, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 29, 29, 95, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 30, 30, 100, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 31, 31, 100, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 32, 32, 95, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 33, 33, 90, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 34, 34, 85, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) },
                    { 35, 35, 80, new DateTime(2024, 11, 24, 1, 39, 14, 109, DateTimeKind.Local).AddTicks(974) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ItemId",
                table: "Storages",
                column: "ItemId",
                unique: true);
        }
    }
}
