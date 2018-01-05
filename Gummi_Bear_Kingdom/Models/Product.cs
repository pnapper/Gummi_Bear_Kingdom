using System;
using System.ComponentModel.DataAnnotations;

namespace Gummi_Bear_Kingdom.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
    }
}
