using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.GetByIdCertificateRequest
{
    internal sealed class GetByIdCertificateRequestQueryHandler(
        ICertificateRequestRepository certificateRequestRepository) : IRequestHandler<GetByIdCertificateRequestQuery, Result<CertificateRequest>>
    {
        public async Task<Result<CertificateRequest>> Handle(GetByIdCertificateRequestQuery request, CancellationToken cancellationToken)
        {
            var certificateRequest = await certificateRequestRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificateRequest is null)
            {
                return (500, "Sertifika talebi bulunamadı");
            }

            return certificateRequest;
        }
    }
}
