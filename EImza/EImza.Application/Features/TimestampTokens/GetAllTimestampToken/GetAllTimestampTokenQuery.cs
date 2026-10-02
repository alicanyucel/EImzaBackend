using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.GetAllTimestampToken
{
    public sealed record GetAllTimestampTokenQuery() : IRequest<Result<List<TimestampToken>>>;
}
