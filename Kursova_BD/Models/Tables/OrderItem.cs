using System.ComponentModel.DataAnnotations;

namespace Kursova_BD.Models.Tables
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public Item Item { get; set; }
        [Required]
        public int OrderQuantity { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public int OrderId { get; set; }
        
    }
}
