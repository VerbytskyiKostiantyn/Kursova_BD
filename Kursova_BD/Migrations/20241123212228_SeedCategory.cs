using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kursova_BD.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 1, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\1.img", "М'ясо" },
                    { 2, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\2.img", "Овочі" },
                    { 3, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\3.img", "Фрукти" },
                    { 4, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\4.img", "Риба" },
                    { 5, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\5.img", "Сири" },
                    { 6, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\6.img", "Хліб" },
                    { 7, "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\7.img", "Напої" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
