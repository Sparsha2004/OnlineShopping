﻿namespace OnlineShopping.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual IList<Product>? Products { get; set; } = new List<Product>();
    }
}
