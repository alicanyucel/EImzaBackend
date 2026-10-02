using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Anchors.GetByIdAnchor
{
    internal sealed class GetByIdAnchorQueryHandler(
        IAnchorRepository anchorRepository) : IRequestHandler<GetByIdAnchorQuery, Result<Anchor>>
    {
        public async Task<Result<Anchor>> Handle(GetByIdAnchorQuery request, CancellationToken cancellationToken)
        {
            var anchor = await anchorRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (anchor is null)
            {
                return (500, "Anchor bulunamadı");
            }

            return anchor;
        }
    }
}
