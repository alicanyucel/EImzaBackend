using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.GetByIdOrganization
{
    public sealed record GetByIdOrganizationQuery(Guid Id) : IRequest<Result<Organization>>;
}
