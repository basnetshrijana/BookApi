namespace BookApi.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
    }
}