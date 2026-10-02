using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;
using SignatureEntity = EImza.Domain.Entities.Signature;

namespace EImza.Application.Features.Signatures.GetByIdSignature
{
    internal sealed class GetByIdSignatureQueryHandler(
        ISignatureRepository signatureRepository) : IRequestHandler<GetByIdSignatureQuery, Result<SignatureEntity>>
    {
        public async Task<Result<SignatureEntity>> Handle(GetByIdSignatureQuery request, CancellationToken cancellationToken)
        {
            var signature = await signatureRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signature is null)
            {
                return (500, "İmza bulunamadı");
            }

            return signature;
        }
    }
}
