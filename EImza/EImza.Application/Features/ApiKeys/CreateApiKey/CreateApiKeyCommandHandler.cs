using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.CreateApiKey
{
    internal sealed class CreateApiKeyCommandHandler(
        IApiKeyRepository apiKeyRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateApiKeyCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateApiKeyCommand request, CancellationToken cancellationToken)
        {
            var apiKey = new ApiKey
            {
                Name = request.Name,
                KeyHash = request.KeyHash,
                CreatedByUserId = request.CreatedByUserId,
                CreatedAt = DateTime.UtcNow,
                ExpiresAt = request.ExpiresAt,
                IsRevoked = false
            };

            await apiKeyRepository.AddAsync(apiKey, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return apiKey.Id;
        }
    }
}
