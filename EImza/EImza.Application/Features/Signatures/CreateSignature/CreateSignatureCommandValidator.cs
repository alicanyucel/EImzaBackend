using FluentValidation;

namespace EImza.Application.Features.Signatures.CreateSignature
{
    public sealed class CreateSignatureCommandValidator : AbstractValidator<CreateSignatureCommand>
    {
        public CreateSignatureCommandValidator()
        {
            RuleFor(p => p.DocumentId)
                .NotEmpty().WithMessage("Doküman Id boş olamaz");
            RuleFor(p => p.CertificateId)
                .NotEmpty().WithMessage("Sertifika Id boş olamaz");
            RuleFor(p => p.SignatureValue)
                .NotEmpty().WithMessage("İmza değeri boş olamaz");
        }
    }
}
