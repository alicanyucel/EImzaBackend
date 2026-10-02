using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.GetByIdApiKey
{
    internal sealed class GetByIdApiKeyQueryHandler(
        IApiKeyRepository apiKeyRepository) : IRequestHandler<GetByIdApiKeyQuery, Result<ApiKey>>
    {
        public async Task<Result<ApiKey>> Handle(GetByIdApiKeyQuery request, CancellationToken cancellationToken)
        {
            var apiKey = await apiKeyRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (apiKey is null)
            {
                return (500, "API anahtarı bulunamadı");
            }

            return apiKey;
        }
    }
}
