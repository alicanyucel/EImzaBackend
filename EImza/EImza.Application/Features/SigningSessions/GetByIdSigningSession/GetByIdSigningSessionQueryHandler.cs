using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.GetByIdSigningSession
{
    internal sealed class GetByIdSigningSessionQueryHandler(
        ISigningSessionRepository signingSessionRepository) : IRequestHandler<GetByIdSigningSessionQuery, Result<SigningSession>>
    {
        public async Task<Result<SigningSession>> Handle(GetByIdSigningSessionQuery request, CancellationToken cancellationToken)
        {
            var signingSession = await signingSessionRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signingSession is null)
            {
                return (500, "İmza oturumu bulunamadı");
            }

            return signingSession;
        }
    }
}
