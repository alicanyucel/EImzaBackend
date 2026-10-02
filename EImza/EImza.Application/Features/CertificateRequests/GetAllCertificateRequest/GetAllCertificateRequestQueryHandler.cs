using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.GetAllCertificateRequest
{
    internal sealed class GetAllCertificateRequestQueryHandler(
        ICertificateRequestRepository certificateRequestRepository) : IRequestHandler<GetAllCertificateRequestQuery, Result<List<CertificateRequest>>>
    {
        public async Task<Result<List<CertificateRequest>>> Handle(GetAllCertificateRequestQuery request, CancellationToken cancellationToken)
        {
            var certificateRequests = await certificateRequestRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return certificateRequests;
        }
    }
}
