using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.UpdateOrganization
{
    internal sealed class UpdateOrganizationCommandHandler(
        IOrganizationRepository organizationRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateOrganizationCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = await organizationRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (organization is null)
            {
                return (500, "Organizasyon bulunamadı");
            }

            organization.Name = request.Name;
            organization.TaxId = request.TaxId;
            organization.Address = request.Address;
            organization.ContactEmail = request.ContactEmail;
            organization.IsActive = request.IsActive;

            organizationRepository.Update(organization);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
