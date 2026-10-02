using MediatR;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.CreateApiKey
{
    public sealed record CreateApiKeyCommand(
        string Name,
        string KeyHash,
        Guid CreatedByUserId,
        DateTime? ExpiresAt) : IRequest<Result<Guid>>;
}
