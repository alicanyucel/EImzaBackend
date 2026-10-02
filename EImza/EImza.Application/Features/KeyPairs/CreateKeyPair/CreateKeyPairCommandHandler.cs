using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.CreateKeyPair
{
    internal sealed class CreateKeyPairCommandHandler(
        IKeyPairRepository keyPairRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateKeyPairCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateKeyPairCommand request, CancellationToken cancellationToken)
        {
            var keyPair = new KeyPair
            {
                OwnerId = request.OwnerId,
                KeyType = request.KeyType,
                PublicKey = request.PublicKey,
                EncryptedPrivateKey = request.EncryptedPrivateKey,
                CreatedAt = DateTime.UtcNow
            };

            await keyPairRepository.AddAsync(keyPair, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return keyPair.Id;
        }
    }
}
