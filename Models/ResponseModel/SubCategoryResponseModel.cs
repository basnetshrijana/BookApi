using System.ComponentModel.DataAnnotations.Schema;
using BookApi.Entities;

namespace BookApi.Models.ResponseModel
{
    public class SubCategoryResponseModel
    {
        public Guid SubCategoryId { get; set; }
        public String SubCategoryName { get; set; }

        public virtual Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Categories { get; set; }
    }
}
