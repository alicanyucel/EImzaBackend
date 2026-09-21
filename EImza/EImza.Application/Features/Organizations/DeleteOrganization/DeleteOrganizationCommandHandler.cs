using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.DeleteOrganization
{
    internal sealed class DeleteOrganizationCommandHandler(
        IOrganizationRepository organizationRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteOrganizationCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = await organizationRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (organization is null)
            {
                return (500, "Organizasyon bulunamadı");
            }

            organizationRepository.Delete(organization);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
