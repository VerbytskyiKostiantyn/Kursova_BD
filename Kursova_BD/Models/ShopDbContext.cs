using Kursova_BD.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace Kursova_BD.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
            
        }
        public DbSet<Item> items {  get; set; }
    }
}
