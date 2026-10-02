using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.DeleteApiKey
{
    internal sealed class DeleteApiKeyCommandHandler(
        IApiKeyRepository apiKeyRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteApiKeyCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteApiKeyCommand request, CancellationToken cancellationToken)
        {
            var apiKey = await apiKeyRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (apiKey is null)
            {
                return (500, "API anahtarı bulunamadı");
            }

            apiKeyRepository.Delete(apiKey);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
