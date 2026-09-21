using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.CreateOrganization
{
    public sealed record CreateOrganizationCommand(
        string Name,
        string? TaxId,
        string? Address,
        string? ContactEmail) : IRequest<Result<Guid>>;
}
