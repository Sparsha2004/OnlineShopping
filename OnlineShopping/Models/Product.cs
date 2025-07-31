namespace OnlineShopping.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; }

        // NOTE: Fix this to set the ProductPhoto as non-nullable
        public string? ProductPhoto { get; set; }
        public int CategoryId { get; set; }
        
        // Navigation property for related category
        public virtual Category? Category { get; set; } = new Category();
    }
}
