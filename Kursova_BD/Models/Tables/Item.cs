﻿using System.ComponentModel.DataAnnotations;

namespace Kursova_BD.Models.Tables
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}
