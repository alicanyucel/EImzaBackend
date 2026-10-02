using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.GetAllSigningSession
{
    internal sealed class GetAllSigningSessionQueryHandler(
        ISigningSessionRepository signingSessionRepository) : IRequestHandler<GetAllSigningSessionQuery, Result<List<SigningSession>>>
    {
        public async Task<Result<List<SigningSession>>> Handle(GetAllSigningSessionQuery request, CancellationToken cancellationToken)
        {
            var signingSessions = await signingSessionRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return signingSessions;
        }
    }
}
