using MediatR;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.DeleteTimestampToken
{
    public sealed record DeleteTimestampTokenCommand(Guid Id) : IRequest<Result<bool>>;
}
