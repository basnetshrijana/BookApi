using System.ComponentModel.DataAnnotations.Schema;

namespace BookApi.Entities
{
    public class SubCategory : AuditableEntity
    {
        public Guid SubCategoryId{get;set;}
        public string SubCategoryName{get;set;}
        public virtual Guid CategoryId{get;set;}

        [ForeignKey("CategoryId")]
        public virtual Category Categories{get;set;}
    }
}