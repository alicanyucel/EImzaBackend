using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.CreateSignatureRequest
{
    internal sealed class CreateSignatureRequestCommandHandler(
        ISignatureRequestRepository signatureRequestRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateSignatureRequestCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateSignatureRequestCommand request, CancellationToken cancellationToken)
        {
            var signatureRequest = new SignatureRequest
            {
                DocumentId = request.DocumentId,
                RequestedByUserId = request.RequestedByUserId,
                RequestedSignerCertificateIds = request.RequestedSignerCertificateIds,
                RequestedAt = DateTime.UtcNow,
                ExpiresAt = request.ExpiresAt,
                Status = "Pending"
            };

            await signatureRequestRepository.AddAsync(signatureRequest, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return signatureRequest.Id;
        }
    }
}
