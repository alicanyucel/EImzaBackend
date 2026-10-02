using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.CreateSignatureRequest
{
    public sealed record CreateSignatureRequestCommand(
        Guid DocumentId,
        Guid RequestedByUserId,
        List<Guid> RequestedSignerCertificateIds,
        DateTime? ExpiresAt) : IRequest<Result<Guid>>;
}
