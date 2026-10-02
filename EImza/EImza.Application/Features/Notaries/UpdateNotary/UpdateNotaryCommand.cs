using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.UpdateNotary
{
    public sealed record UpdateNotaryCommand(
        Guid Id,
        string Name,
        string? RegistrationNumber,
        string? Contact) : IRequest<Result<bool>>;
}
