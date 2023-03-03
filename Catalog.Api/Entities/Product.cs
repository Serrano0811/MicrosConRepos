namespace Catalog.Api.Entities
{
    public class Product
    {
        public string id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Summary { get; set; }
        public string PhotoUrl { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
