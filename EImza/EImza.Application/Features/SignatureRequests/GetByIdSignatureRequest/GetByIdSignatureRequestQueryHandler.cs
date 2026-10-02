using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.GetByIdSignatureRequest
{
    internal sealed class GetByIdSignatureRequestQueryHandler(
        ISignatureRequestRepository signatureRequestRepository) : IRequestHandler<GetByIdSignatureRequestQuery, Result<SignatureRequest>>
    {
        public async Task<Result<SignatureRequest>> Handle(GetByIdSignatureRequestQuery request, CancellationToken cancellationToken)
        {
            var signatureRequest = await signatureRequestRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signatureRequest is null)
            {
                return (500, "İmza talebi bulunamadı");
            }

            return signatureRequest;
        }
    }
}
