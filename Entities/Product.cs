namespace BookApi.Entities
{
    public class Product : AuditableEntity
    {
        public Guid ProductId{get;set;}
        public string ProductName { get; set; }    
        public decimal ProductPrice { get; set; }
        
    }
}