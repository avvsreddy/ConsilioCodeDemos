namespace ProductsCatalogService.API.Model.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
    }
}
