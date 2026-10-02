using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.GetAllCertificateAuthority
{
    internal sealed class GetAllCertificateAuthorityQueryHandler(
        ICertificateAuthorityRepository certificateAuthorityRepository) : IRequestHandler<GetAllCertificateAuthorityQuery, Result<List<CertificateAuthority>>>
    {
        public async Task<Result<List<CertificateAuthority>>> Handle(GetAllCertificateAuthorityQuery request, CancellationToken cancellationToken)
        {
            var certificateAuthorities = await certificateAuthorityRepository.GetAll()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            return certificateAuthorities;
        }
    }
}
