using Kursova_BD.Models.Tables;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Kursova_BD.Models
{
    public class ShopDbContext : DbContext
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ShopDbContext(DbContextOptions<ShopDbContext> options, IWebHostEnvironment webHostEnvironment) : base(options)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            var uploads = Path.Combine(wwwRootPath, "images");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "М'ясо", ImagePath = "/images/1.jpg" },
                    new Category { Id = 2, Name = "Овочі", ImagePath = "/images/2.jpg" },
                    new Category { Id = 3, Name = "Фрукти", ImagePath = "/images/3.jpg" },
                    new Category { Id = 4, Name = "Риба", ImagePath = "/images/4.jpg" },
                    new Category { Id = 5, Name = "Сири", ImagePath = "/images/5.jpg" },
                    new Category { Id = 6, Name = "Хліб", ImagePath = "/images/6.jpg" },
                    new Category { Id = 7, Name = "Напої", ImagePath = "/images/7.jpg" }
            );

            modelBuilder.Entity<Item>().HasData(
                    // Категорія М'ясо
                    new Item { Id = 1, Name = "Свинина", Price = 50, CategoryId = 1, ImagePath = "/images/8.jpg" },
                    new Item { Id = 2, Name = "Телятина", Price = 45, CategoryId = 1, ImagePath = "/images/9.jpg" },
                    new Item { Id = 3, Name = "Курка", Price = 35, CategoryId = 1, ImagePath = "/images/10.jpg" },
                    new Item { Id = 4, Name = "Качка", Price = 40, CategoryId = 1, ImagePath = "/images/11.jpg" },
                    new Item { Id = 5, Name = "Індичка", Price = 30, CategoryId = 1, ImagePath = "/images/12.jpg" },

                    // Категорія Овочі
                    new Item { Id = 6, Name = "Помідор", Price = 15, CategoryId = 2, ImagePath = "/images/13.jpg" },
                    new Item { Id = 7, Name = "Морква", Price = 12, CategoryId = 2, ImagePath = "/images/14.jpg" },
                    new Item { Id = 8, Name = "Цибуля", Price = 8, CategoryId = 2, ImagePath = "/images/15.jpg" },
                    new Item { Id = 9, Name = "Капуста", Price = 20, CategoryId = 2, ImagePath = "/images/16.jpg" },
                    new Item { Id = 10, Name = "Огірок", Price = 18, CategoryId = 2, ImagePath = "/images/17.jpg" },

                    // Категорія Фрукти
                    new Item { Id = 11, Name = "Яблуко", Price = 25, CategoryId = 3, ImagePath = "/images/18.jpg" },
                    new Item { Id = 12, Name = "Банан", Price = 15, CategoryId = 3, ImagePath = "/images/19.jpg" },
                    new Item { Id = 13, Name = "Апельсин", Price = 22, CategoryId = 3, ImagePath = "/images/20.jpg" },
                    new Item { Id = 14, Name = "Манго", Price = 30, CategoryId = 3, ImagePath = "/images/21.jpg" },
                    new Item { Id = 15, Name = "Лимон", Price = 18, CategoryId = 3, ImagePath = "/images/22.jpg" },

                    // Категорія Риба
                    new Item { Id = 16, Name = "Карась", Price = 35, CategoryId = 4, ImagePath = "/images/23.jpg" },
                    new Item { Id = 17, Name = "Короп", Price = 40, CategoryId = 4, ImagePath = "/images/24.jpg" },
                    new Item { Id = 18, Name = "Лосось", Price = 45, CategoryId = 4, ImagePath = "/images/25.jpg" },
                    new Item { Id = 19, Name = "Скумбрія", Price = 38, CategoryId = 4, ImagePath = "/images/26.jpg" },
                    new Item { Id = 20, Name = "Окунь", Price = 32, CategoryId = 4, ImagePath = "/images/27.jpg" },

                    // Категорія Сири
                    new Item { Id = 21, Name = "Фета", Price = 25, CategoryId = 5, ImagePath = "/images/28.jpg" },
                    new Item { Id = 22, Name = "Домашній", Price = 28, CategoryId = 5, ImagePath = "/images/29.jpg" },
                    new Item { Id = 23, Name = "Брі", Price = 30, CategoryId = 5, ImagePath = "/images/30.jpg" },
                    new Item { Id = 24, Name = "Моцарелла", Price = 22, CategoryId = 5, ImagePath = "/images/31.jpg" },
                    new Item { Id = 25, Name = "Пармезан", Price = 35, CategoryId = 5, ImagePath = "/images/32.jpg" },

                    // Категорія Хліб
                    new Item { Id = 26, Name = "Багет", Price = 15, CategoryId = 6, ImagePath = "/images/33.jpg" },
                    new Item { Id = 27, Name = "Батон", Price = 10, CategoryId = 6, ImagePath = "/images/34.jpg" },
                    new Item { Id = 28, Name = "Український", Price = 20, CategoryId = 6, ImagePath = "/images/35.jpg" },
                    new Item { Id = 29, Name = "Пампушки", Price = 18, CategoryId = 6, ImagePath = "/images/36.jpg" },
                    new Item { Id = 30, Name = "Лаваш", Price = 12, CategoryId = 6, ImagePath = "/images/37.jpg" },

                    // Категорія Напої
                    new Item { Id = 31, Name = "Горілка", Price = 20, CategoryId = 7, ImagePath = "/images/38.jpg" },
                    new Item { Id = 32, Name = "Червоне вино", Price = 35, CategoryId = 7, ImagePath = "/images/39.jpg" },
                    new Item { Id = 33, Name = "Біле вино", Price = 40, CategoryId = 7, ImagePath = "/images/40.jpg" },
                    new Item { Id = 34, Name = "Пиво", Price = 25, CategoryId = 7, ImagePath = "/images/41.jpg" },
                    new Item { Id = 35, Name = "Сік", Price = 18, CategoryId = 7, ImagePath = "/images/42.jpg" }
            );

        }
    }
}
