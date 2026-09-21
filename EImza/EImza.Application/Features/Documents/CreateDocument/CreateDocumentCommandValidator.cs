using FluentValidation;

namespace EImza.Application.Features.Documents.CreateDocument
{
    public sealed class CreateDocumentCommandValidator : AbstractValidator<CreateDocumentCommand>
    {
        public CreateDocumentCommandValidator()
        {
            RuleFor(p => p.FileName)
                .NotEmpty().WithMessage("Dosya adı boş olamaz")
                .MaximumLength(255).WithMessage("Dosya adı en fazla 255 karakter olabilir");
            RuleFor(p => p.ContentType)
                .NotEmpty().WithMessage("İçerik tipi boş olamaz");
            RuleFor(p => p.Size)
                .GreaterThan(0).WithMessage("Dosya boyutu 0'dan büyük olmalıdır");
        }
    }
}
