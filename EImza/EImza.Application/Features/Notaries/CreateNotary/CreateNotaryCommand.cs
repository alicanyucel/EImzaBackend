using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.CreateNotary
{
    public sealed record CreateNotaryCommand(
        string Name,
        string? RegistrationNumber,
        string? Contact) : IRequest<Result<Guid>>;
}
