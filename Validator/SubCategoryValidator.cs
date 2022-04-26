using BookApi.Models.RequestModel;
using FluentValidation;

namespace BookApi.Validator
{
    public class SubCategoryValidator : AbstractValidator<SubCategoryRequestModel>
    {
        public SubCategoryValidator()
        {
            RuleFor(x => x.SubCategoryName).NotNull().NotEmpty().WithMessage("Required author name");
        }
    }
}