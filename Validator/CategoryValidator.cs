using BookApi.Models.RequestModel;
using FluentValidation;

namespace BookApi.Validator
{
    public class CategoryValidator : AbstractValidator<CategoryRequestModel>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotNull().NotEmpty().WithMessage("Required author name");
        }
        
    }
}