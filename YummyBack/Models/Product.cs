using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yummy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool isDeleted { get; set; }
        public int CategoryId { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public Category Category { get; set; }
    }
}
