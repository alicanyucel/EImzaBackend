using FluentValidation;

namespace EImza.Application.Features.CertificateAuthorities.CreateCertificateAuthority
{
    public sealed class CreateCertificateAuthorityCommandValidator : AbstractValidator<CreateCertificateAuthorityCommand>
    {
        public CreateCertificateAuthorityCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Otorite adı boş olamaz")
                .MaximumLength(200).WithMessage("Otorite adı en fazla 200 karakter olabilir");
        }
    }
}
