using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.GetAllApiKey
{
    internal sealed class GetAllApiKeyQueryHandler(
        IApiKeyRepository apiKeyRepository) : IRequestHandler<GetAllApiKeyQuery, Result<List<ApiKey>>>
    {
        public async Task<Result<List<ApiKey>>> Handle(GetAllApiKeyQuery request, CancellationToken cancellationToken)
        {
            var apiKeys = await apiKeyRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return apiKeys;
        }
    }
}
