using FluentValidation;

namespace EImza.Application.Features.SignatureRequests.CreateSignatureRequest
{
    public sealed class CreateSignatureRequestCommandValidator : AbstractValidator<CreateSignatureRequestCommand>
    {
        public CreateSignatureRequestCommandValidator()
        {
            RuleFor(p => p.DocumentId)
                .NotEmpty().WithMessage("Doküman Id boş olamaz");
            RuleFor(p => p.RequestedByUserId)
                .NotEmpty().WithMessage("Talep eden kullanıcı Id boş olamaz");
            RuleFor(p => p.RequestedSignerCertificateIds)
                .NotEmpty().WithMessage("En az bir imzacı sertifikası seçilmelidir");
        }
    }
}
