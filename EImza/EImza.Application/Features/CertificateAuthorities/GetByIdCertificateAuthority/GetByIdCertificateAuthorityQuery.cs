using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.GetByIdCertificateAuthority
{
    public sealed record GetByIdCertificateAuthorityQuery(Guid Id) : IRequest<Result<CertificateAuthority>>;
}
