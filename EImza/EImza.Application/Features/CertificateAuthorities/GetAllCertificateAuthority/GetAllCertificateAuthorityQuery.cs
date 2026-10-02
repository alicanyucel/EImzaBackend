using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.GetAllCertificateAuthority
{
    public sealed record GetAllCertificateAuthorityQuery() : IRequest<Result<List<CertificateAuthority>>>;
}
