using MediatR;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.CreateSigningSession
{
    public sealed record CreateSigningSessionCommand(
        Guid SignatureRequestId,
        Guid SignerCertificateId,
        string SessionToken,
        DateTime ExpiresAt) : IRequest<Result<Guid>>;
}
