﻿using System.Collections.Generic;

namespace Yummy.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public List<Product> Products { get; set; }
    }
}
