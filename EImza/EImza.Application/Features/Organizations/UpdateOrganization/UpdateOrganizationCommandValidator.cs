using FluentValidation;

namespace EImza.Application.Features.Organizations.UpdateOrganization
{
    public sealed class UpdateOrganizationCommandValidator : AbstractValidator<UpdateOrganizationCommand>
    {
        public UpdateOrganizationCommandValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("Id boş olamaz");
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Organizasyon adı boş olamaz")
                .MaximumLength(200).WithMessage("Organizasyon adı en fazla 200 karakter olabilir");
            RuleFor(p => p.ContactEmail)
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz")
                .When(p => !string.IsNullOrEmpty(p.ContactEmail));
        }
    }
}
