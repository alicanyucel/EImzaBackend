using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.UpdateSignatureRequest
{
    public sealed record UpdateSignatureRequestCommand(
        Guid Id,
        string Status,
        DateTime? ExpiresAt) : IRequest<Result<bool>>;
}
