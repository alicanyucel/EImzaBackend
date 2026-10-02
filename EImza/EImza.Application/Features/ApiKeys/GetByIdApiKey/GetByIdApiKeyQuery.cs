using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.GetByIdApiKey
{
    public sealed record GetByIdApiKeyQuery(Guid Id) : IRequest<Result<ApiKey>>;
}
