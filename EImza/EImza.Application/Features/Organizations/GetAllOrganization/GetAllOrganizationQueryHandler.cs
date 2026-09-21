using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.Organizations.GetAllOrganization
{
    internal sealed class GetAllOrganizationQueryHandler(
        IOrganizationRepository organizationRepository) : IRequestHandler<GetAllOrganizationQuery, Result<List<Organization>>>
    {
        public async Task<Result<List<Organization>>> Handle(GetAllOrganizationQuery request, CancellationToken cancellationToken)
        {
            var organizations = await organizationRepository.GetAll()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            return organizations;
        }
    }
}
