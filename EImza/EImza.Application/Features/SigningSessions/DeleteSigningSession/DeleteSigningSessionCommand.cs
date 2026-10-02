using MediatR;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.DeleteSigningSession
{
    public sealed record DeleteSigningSessionCommand(Guid Id) : IRequest<Result<bool>>;
}
