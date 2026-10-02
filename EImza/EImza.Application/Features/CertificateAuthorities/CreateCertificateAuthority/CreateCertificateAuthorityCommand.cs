using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.CreateCertificateAuthority
{
    public sealed record CreateCertificateAuthorityCommand(
        string Name,
        string? Url,
        bool IsTrusted) : IRequest<Result<Guid>>;
}
