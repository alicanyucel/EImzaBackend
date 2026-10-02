using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.CreateSigningSession
{
    internal sealed class CreateSigningSessionCommandHandler(
        ISigningSessionRepository signingSessionRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateSigningSessionCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateSigningSessionCommand request, CancellationToken cancellationToken)
        {
            var signingSession = new SigningSession
            {
                SignatureRequestId = request.SignatureRequestId,
                SignerCertificateId = request.SignerCertificateId,
                SessionToken = request.SessionToken,
                CreatedAt = DateTime.UtcNow,
                ExpiresAt = request.ExpiresAt,
                Status = "Pending"
            };

            await signingSessionRepository.AddAsync(signingSession, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return signingSession.Id;
        }
    }
}
