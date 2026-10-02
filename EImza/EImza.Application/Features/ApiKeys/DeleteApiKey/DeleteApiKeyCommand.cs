using MediatR;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.DeleteApiKey
{
    public sealed record DeleteApiKeyCommand(Guid Id) : IRequest<Result<bool>>;
}
