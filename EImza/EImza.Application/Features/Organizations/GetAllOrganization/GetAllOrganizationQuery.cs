using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.GetAllOrganization
{
    public sealed record GetAllOrganizationQuery() : IRequest<Result<List<Organization>>>;
}
