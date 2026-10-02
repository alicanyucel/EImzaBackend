using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Anchors.CreateAnchor
{
    internal sealed class CreateAnchorCommandHandler(
        IAnchorRepository anchorRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateAnchorCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateAnchorCommand request, CancellationToken cancellationToken)
        {
            var anchor = new Anchor
            {
                DocumentId = request.DocumentId,
                AnchorType = request.AnchorType,
                Reference = request.Reference,
                CreatedAt = DateTime.UtcNow
            };

            await anchorRepository.AddAsync(anchor, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return anchor.Id;
        }
    }
}
