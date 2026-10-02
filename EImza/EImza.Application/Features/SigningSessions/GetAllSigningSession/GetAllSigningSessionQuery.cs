using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.GetAllSigningSession
{
    public sealed record GetAllSigningSessionQuery() : IRequest<Result<List<SigningSession>>>;
}
