using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ApiKeys.GetAllApiKey
{
    public sealed record GetAllApiKeyQuery() : IRequest<Result<List<ApiKey>>>;
}
