using FluentValidation;

namespace MFU.Models.ValidationRules
{
    public class DocumentCategoryValidator : AbstractValidator<DocumentCategory>
    {
        public DocumentCategoryValidator()
        {
            RuleFor(documentCategory => documentCategory.Id).NotEmpty();
            RuleFor(documentCategory => documentCategory.CreatedDate).NotEmpty();
            RuleFor(documentCategory => documentCategory.ModifiedDate).NotEmpty();

            RuleFor(documentCategory => documentCategory.Name).NotEmpty().MaximumLength(50);
            RuleFor(documentCategory => documentCategory.Description).MaximumLength(255);
            RuleFor(model => model.Documents)
                .SetCollectionValidator(new DocumentValidator());
        }
    }
}
