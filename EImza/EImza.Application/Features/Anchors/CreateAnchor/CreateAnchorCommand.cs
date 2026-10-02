using MediatR;
using TS.Result;

namespace EImza.Application.Features.Anchors.CreateAnchor
{
    public sealed record CreateAnchorCommand(
        Guid DocumentId,
        string AnchorType,
        string Reference) : IRequest<Result<Guid>>;
}
