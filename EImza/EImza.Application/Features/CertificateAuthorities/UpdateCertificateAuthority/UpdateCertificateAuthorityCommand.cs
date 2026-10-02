using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.UpdateCertificateAuthority
{
    public sealed record UpdateCertificateAuthorityCommand(
        Guid Id,
        string Name,
        string? Url,
        bool IsTrusted) : IRequest<Result<bool>>;
}
