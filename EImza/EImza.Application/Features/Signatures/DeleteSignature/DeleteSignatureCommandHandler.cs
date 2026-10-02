using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Signatures.DeleteSignature
{
    internal sealed class DeleteSignatureCommandHandler(
        ISignatureRepository signatureRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteSignatureCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteSignatureCommand request, CancellationToken cancellationToken)
        {
            var signature = await signatureRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signature is null)
            {
                return (500, "İmza bulunamadı");
            }

            signatureRepository.Delete(signature);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
