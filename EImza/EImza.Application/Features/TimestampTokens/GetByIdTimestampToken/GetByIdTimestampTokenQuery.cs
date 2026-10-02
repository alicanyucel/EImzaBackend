using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.GetByIdTimestampToken
{
    public sealed record GetByIdTimestampTokenQuery(Guid Id) : IRequest<Result<TimestampToken>>;
}
