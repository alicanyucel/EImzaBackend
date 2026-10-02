using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.DeleteCertificateAuthority
{
    public sealed record DeleteCertificateAuthorityCommand(Guid Id) : IRequest<Result<bool>>;
}
