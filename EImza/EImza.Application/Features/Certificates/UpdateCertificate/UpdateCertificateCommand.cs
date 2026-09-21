using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.UpdateCertificate
{
    public sealed record UpdateCertificateCommand(
        Guid Id,
        string SerialNumber,
        Guid? AuthorityId,
        Guid? OwnerUserId,
        Guid? OrganizationId,
        DateTime IssuedAt,
        DateTime ExpiresAt,
        bool IsRevoked,
        string? RawDataBase64) : IRequest<Result<bool>>;
}
