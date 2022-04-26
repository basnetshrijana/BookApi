namespace BookApi.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
