using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.GetByIdKeyPair
{
    internal sealed class GetByIdKeyPairQueryHandler(
        IKeyPairRepository keyPairRepository) : IRequestHandler<GetByIdKeyPairQuery, Result<KeyPair>>
    {
        public async Task<Result<KeyPair>> Handle(GetByIdKeyPairQuery request, CancellationToken cancellationToken)
        {
            var keyPair = await keyPairRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (keyPair is null)
            {
                return (500, "Anahtar çifti bulunamadı");
            }

            return keyPair;
        }
    }
}
