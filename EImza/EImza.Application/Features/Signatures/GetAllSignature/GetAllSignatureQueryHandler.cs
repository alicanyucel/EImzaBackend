using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;
using SignatureEntity = EImza.Domain.Entities.Signature;

namespace EImza.Application.Features.Signatures.GetAllSignature
{
    internal sealed class GetAllSignatureQueryHandler(
        ISignatureRepository signatureRepository) : IRequestHandler<GetAllSignatureQuery, Result<List<SignatureEntity>>>
    {
        public async Task<Result<List<SignatureEntity>>> Handle(GetAllSignatureQuery request, CancellationToken cancellationToken)
        {
            var signatures = await signatureRepository.GetAll()
                .OrderByDescending(p => p.SignedAt)
                .ToListAsync(cancellationToken);

            return signatures;
        }
    }
}
