using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.GetByIdOrganization
{
    internal sealed class GetByIdOrganizationQueryHandler(
        IOrganizationRepository organizationRepository) : IRequestHandler<GetByIdOrganizationQuery, Result<Organization>>
    {
        public async Task<Result<Organization>> Handle(GetByIdOrganizationQuery request, CancellationToken cancellationToken)
        {
            var organization = await organizationRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (organization is null)
            {
                return Result.Failure("Organizasyon bulunamadı");
            }

            return organization;
        }
    }
}
