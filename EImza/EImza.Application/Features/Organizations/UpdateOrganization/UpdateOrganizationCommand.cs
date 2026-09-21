using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.UpdateOrganization
{
    public sealed record UpdateOrganizationCommand(
        Guid Id,
        string Name,
        string? TaxId,
        string? Address,
        string? ContactEmail,
        bool IsActive) : IRequest<Result<bool>>;
}
