using FluentValidation;

namespace EImza.Application.Features.Certificates.CreateCertificate
{
    public sealed class CreateCertificateCommandValidator : AbstractValidator<CreateCertificateCommand>
    {
        public CreateCertificateCommandValidator()
        {
            RuleFor(p => p.SerialNumber)
                .NotEmpty().WithMessage("Seri numarası boş olamaz")
                .MaximumLength(100).WithMessage("Seri numarası en fazla 100 karakter olabilir");
            RuleFor(p => p.IssuedAt)
                .NotEmpty().WithMessage("Veriliş tarihi boş olamaz");
            RuleFor(p => p.ExpiresAt)
                .NotEmpty().WithMessage("Son kullanma tarihi boş olamaz")
                .GreaterThan(p => p.IssuedAt).WithMessage("Son kullanma tarihi veriliş tarihinden sonra olmalıdır");
        }
    }
}
