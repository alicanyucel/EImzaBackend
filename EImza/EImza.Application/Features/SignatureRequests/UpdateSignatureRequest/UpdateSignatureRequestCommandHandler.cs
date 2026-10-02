using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.UpdateSignatureRequest
{
    internal sealed class UpdateSignatureRequestCommandHandler(
        ISignatureRequestRepository signatureRequestRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateSignatureRequestCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateSignatureRequestCommand request, CancellationToken cancellationToken)
        {
            var signatureRequest = await signatureRequestRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signatureRequest is null)
            {
                return (500, "İmza talebi bulunamadı");
            }

            signatureRequest.Status = request.Status;
            signatureRequest.ExpiresAt = request.ExpiresAt;

            signatureRequestRepository.Update(signatureRequest);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
