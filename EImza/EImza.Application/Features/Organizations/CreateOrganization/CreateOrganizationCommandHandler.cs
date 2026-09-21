using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.CreateOrganization
{
    internal sealed class CreateOrganizationCommandHandler(
        IOrganizationRepository organizationRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateOrganizationCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = new Organization
            {
                Name = request.Name,
                TaxId = request.TaxId,
                Address = request.Address,
                ContactEmail = request.ContactEmail,
                IsActive = true
            };

            await organizationRepository.AddAsync(organization, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return organization.Id;
        }
    }
}
