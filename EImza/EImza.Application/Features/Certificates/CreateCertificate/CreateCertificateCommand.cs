using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.CreateCertificate
{
    public sealed record CreateCertificateCommand(
        string SerialNumber,
        Guid? AuthorityId,
        Guid? OwnerUserId,
        Guid? OrganizationId,
        DateTime IssuedAt,
        DateTime ExpiresAt,
        string? RawDataBase64) : IRequest<Result<Guid>>;
}
