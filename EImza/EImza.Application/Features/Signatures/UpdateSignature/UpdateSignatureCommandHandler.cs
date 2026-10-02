using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Signatures.UpdateSignature
{
    internal sealed class UpdateSignatureCommandHandler(
        ISignatureRepository signatureRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateSignatureCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateSignatureCommand request, CancellationToken cancellationToken)
        {
            var signature = await signatureRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signature is null)
            {
                return (500, "İmza bulunamadı");
            }

            signature.Status = request.Status;
            signature.Reason = request.Reason;

            signatureRepository.Update(signature);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
