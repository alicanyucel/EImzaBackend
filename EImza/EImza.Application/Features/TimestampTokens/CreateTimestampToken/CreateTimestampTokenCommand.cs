using MediatR;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.CreateTimestampToken
{
    public sealed record CreateTimestampTokenCommand(
        string TokenBase64,
        Guid CreatedByUserId,
        Guid DocumentId) : IRequest<Result<Guid>>;
}
