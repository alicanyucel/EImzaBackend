using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.Certificates.GetAllCertificate
{
    internal sealed class GetAllCertificateQueryHandler(
        ICertificateRepository certificateRepository) : IRequestHandler<GetAllCertificateQuery, Result<List<Certificate>>>
    {
        public async Task<Result<List<Certificate>>> Handle(GetAllCertificateQuery request, CancellationToken cancellationToken)
        {
            var certificates = await certificateRepository.GetAll()
                .OrderByDescending(p => p.IssuedAt)
                .ToListAsync(cancellationToken);

            return certificates;
        }
    }
}
