using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.GetByIdSigningSession
{
    public sealed record GetByIdSigningSessionQuery(Guid Id) : IRequest<Result<SigningSession>>;
}
