using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.Anchors.GetAllAnchor
{
    internal sealed class GetAllAnchorQueryHandler(
        IAnchorRepository anchorRepository) : IRequestHandler<GetAllAnchorQuery, Result<List<Anchor>>>
    {
        public async Task<Result<List<Anchor>>> Handle(GetAllAnchorQuery request, CancellationToken cancellationToken)
        {
            var anchors = await anchorRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return anchors;
        }
    }
}
