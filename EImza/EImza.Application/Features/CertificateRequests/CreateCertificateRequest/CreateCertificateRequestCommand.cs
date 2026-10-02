using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.CreateCertificateRequest
{
    public sealed record CreateCertificateRequestCommand(
        Guid RequesterUserId,
        Guid? OrganizationId,
        string Csr) : IRequest<Result<Guid>>;
}
