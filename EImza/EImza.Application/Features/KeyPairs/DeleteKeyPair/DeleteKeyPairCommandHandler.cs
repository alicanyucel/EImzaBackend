using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.DeleteKeyPair
{
    internal sealed class DeleteKeyPairCommandHandler(
        IKeyPairRepository keyPairRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteKeyPairCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteKeyPairCommand request, CancellationToken cancellationToken)
        {
            var keyPair = await keyPairRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (keyPair is null)
            {
                return (500, "Anahtar çifti bulunamadı");
            }

            keyPairRepository.Delete(keyPair);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
