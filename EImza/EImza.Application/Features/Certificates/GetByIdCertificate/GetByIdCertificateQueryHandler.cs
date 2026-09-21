using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.GetByIdCertificate
{
    internal sealed class GetByIdCertificateQueryHandler(
        ICertificateRepository certificateRepository) : IRequestHandler<GetByIdCertificateQuery, Result<Certificate>>
    {
        public async Task<Result<Certificate>> Handle(GetByIdCertificateQuery request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificate is null)
            {
                return (500, "Sertifika bulunamadı");
            }

            return certificate;
        }
    }
}
