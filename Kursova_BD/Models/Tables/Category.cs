using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Kursova_BD.Models.Tables
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [JsonIgnore]
        public List<Item>? Items { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}
