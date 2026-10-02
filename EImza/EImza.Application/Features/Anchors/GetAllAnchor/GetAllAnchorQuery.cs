using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Anchors.GetAllAnchor
{
    public sealed record GetAllAnchorQuery() : IRequest<Result<List<Anchor>>>;
}
