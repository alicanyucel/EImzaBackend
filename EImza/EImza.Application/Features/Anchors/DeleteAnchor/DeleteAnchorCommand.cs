using MediatR;
using TS.Result;

namespace EImza.Application.Features.Anchors.DeleteAnchor
{
    public sealed record DeleteAnchorCommand(Guid Id) : IRequest<Result<bool>>;
}
