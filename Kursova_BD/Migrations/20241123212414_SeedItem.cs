using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kursova_BD.Migrations
{
    /// <inheritdoc />
    public partial class SeedItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\8.img", "Свинина", 50 },
                    { 2, 1, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\9.img", "Телятина", 45 },
                    { 3, 1, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\10.img", "Курка", 35 },
                    { 4, 1, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\11.img", "Качка", 40 },
                    { 5, 1, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\12.img", "Індичка", 30 },
                    { 6, 2, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\13.img", "Помідор", 15 },
                    { 7, 2, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\14.img", "Морква", 12 },
                    { 8, 2, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\15.img", "Цибуля", 8 },
                    { 9, 2, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\16.img", "Капуста", 20 },
                    { 10, 2, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\17.img", "Огірок", 18 },
                    { 11, 3, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\18.img", "Яблуко", 25 },
                    { 12, 3, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\19.img", "Банан", 15 },
                    { 13, 3, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\20.img", "Апельсин", 22 },
                    { 14, 3, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\21.img", "Манго", 30 },
                    { 15, 3, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\22.img", "Лимон", 18 },
                    { 16, 4, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\23.img", "Карась", 35 },
                    { 17, 4, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\24.img", "Короп", 40 },
                    { 18, 4, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\25.img", "Лосось", 45 },
                    { 19, 4, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\26.img", "Скумбрія", 38 },
                    { 20, 4, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\27.img", "Окунь", 32 },
                    { 21, 5, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\28.img", "Фета", 25 },
                    { 22, 5, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\29.img", "Домашній", 28 },
                    { 23, 5, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\30.img", "Брі", 30 },
                    { 24, 5, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\31.img", "Моцарелла", 22 },
                    { 25, 5, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\32.img", "Пармезан", 35 },
                    { 26, 6, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\33.img", "Багет", 15 },
                    { 27, 6, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\34.img", "Батон", 10 },
                    { 28, 6, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\35.img", "Український", 20 },
                    { 29, 6, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\36.img", "Помпушки", 18 },
                    { 30, 6, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\37.img", "Лаваш", 12 },
                    { 31, 7, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\38.img", "Кава", 20 },
                    { 32, 7, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\39.img", "Червоне вино", 35 },
                    { 33, 7, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\40.img", "Біле вино", 40 },
                    { 34, 7, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\41.img", "Пиво", 25 },
                    { 35, 7, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\42.img", "Сік", 18 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
