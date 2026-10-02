using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.UpdateCertificateRequest
{
    public sealed record UpdateCertificateRequestCommand(
        Guid Id,
        string Status) : IRequest<Result<bool>>;
}
