using FluentValidation;

namespace EImza.Application.Features.Certificates.UpdateCertificate
{
    public sealed class UpdateCertificateCommandValidator : AbstractValidator<UpdateCertificateCommand>
    {
        public UpdateCertificateCommandValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("Id boş olamaz");
            RuleFor(p => p.SerialNumber)
                .NotEmpty().WithMessage("Seri numarası boş olamaz")
                .MaximumLength(100).WithMessage("Seri numarası en fazla 100 karakter olabilir");
            RuleFor(p => p.ExpiresAt)
                .GreaterThan(p => p.IssuedAt).WithMessage("Son kullanma tarihi veriliş tarihinden sonra olmalıdır");
        }
    }
}
