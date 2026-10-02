using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.DeleteSignatureRequest
{
    internal sealed class DeleteSignatureRequestCommandHandler(
        ISignatureRequestRepository signatureRequestRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteSignatureRequestCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteSignatureRequestCommand request, CancellationToken cancellationToken)
        {
            var signatureRequest = await signatureRequestRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signatureRequest is null)
            {
                return (500, "İmza talebi bulunamadı");
            }

            signatureRequestRepository.Delete(signatureRequest);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
