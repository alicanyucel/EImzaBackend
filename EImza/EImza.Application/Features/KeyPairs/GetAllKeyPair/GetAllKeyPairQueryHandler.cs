using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.GetAllKeyPair
{
    internal sealed class GetAllKeyPairQueryHandler(
        IKeyPairRepository keyPairRepository) : IRequestHandler<GetAllKeyPairQuery, Result<List<KeyPair>>>
    {
        public async Task<Result<List<KeyPair>>> Handle(GetAllKeyPairQuery request, CancellationToken cancellationToken)
        {
            var keyPairs = await keyPairRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return keyPairs;
        }
    }
}
