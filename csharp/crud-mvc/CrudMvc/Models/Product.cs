namespace CrudMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime RecordedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }
    }
}
