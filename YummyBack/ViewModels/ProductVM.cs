using System.Collections.Generic;
using Yummy.Models;

namespace Yummy.ViewModels
{
    public class ProductVM
    {
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
