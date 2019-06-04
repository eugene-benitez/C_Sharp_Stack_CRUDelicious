using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dishes
    {
        // auto-implemented properties need to match the columns in your table
        // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
        [Key]
        public int id { get; set; }
        // MySQL VARCHAR and TEXT types can be represeted by a string
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        public string Chef { get; set; }
        [Required]
        [Range(1, 5)]
        public string Tastiness { get; set; }
        [Required]
        [Range(1, 10000)]
        public string Calories { get; set; }
        [Required]
        [MinLength(3)]
        public string Description { get; set; }

        // The MySQL DATETIME type can be represented by a DateTime
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}