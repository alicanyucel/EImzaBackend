using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Anchors.GetByIdAnchor
{
    public sealed record GetByIdAnchorQuery(Guid Id) : IRequest<Result<Anchor>>;
}
