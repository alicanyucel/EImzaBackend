using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Anchors.DeleteAnchor
{
    internal sealed class DeleteAnchorCommandHandler(
        IAnchorRepository anchorRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteAnchorCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteAnchorCommand request, CancellationToken cancellationToken)
        {
            var anchor = await anchorRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (anchor is null)
            {
                return (500, "Anchor bulunamadı");
            }

            anchorRepository.Delete(anchor);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
