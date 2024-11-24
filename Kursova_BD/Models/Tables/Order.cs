using System.ComponentModel.DataAnnotations;

namespace Kursova_BD.Models.Tables
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateOfOrder { get; set; }
        public List<OrderItem>? Items { get; set; }
        [Required]
        public double TotalOrderPrice { get; set; }
        [Required]
        public string Status {  get; set; }
    }
}
