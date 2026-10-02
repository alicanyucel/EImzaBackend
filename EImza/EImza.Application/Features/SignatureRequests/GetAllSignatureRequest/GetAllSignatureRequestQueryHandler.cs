using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.GetAllSignatureRequest
{
    internal sealed class GetAllSignatureRequestQueryHandler(
        ISignatureRequestRepository signatureRequestRepository) : IRequestHandler<GetAllSignatureRequestQuery, Result<List<SignatureRequest>>>
    {
        public async Task<Result<List<SignatureRequest>>> Handle(GetAllSignatureRequestQuery request, CancellationToken cancellationToken)
        {
            var signatureRequests = await signatureRequestRepository.GetAll()
                .OrderByDescending(p => p.RequestedAt)
                .ToListAsync(cancellationToken);

            return signatureRequests;
        }
    }
}
