using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.GetByIdCertificateAuthority
{
    internal sealed class GetByIdCertificateAuthorityQueryHandler(
        ICertificateAuthorityRepository certificateAuthorityRepository) : IRequestHandler<GetByIdCertificateAuthorityQuery, Result<CertificateAuthority>>
    {
        public async Task<Result<CertificateAuthority>> Handle(GetByIdCertificateAuthorityQuery request, CancellationToken cancellationToken)
        {
            var certificateAuthority = await certificateAuthorityRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificateAuthority is null)
            {
                return (500, "Sertifika otoritesi bulunamadı");
            }

            return certificateAuthority;
        }
    }
}
