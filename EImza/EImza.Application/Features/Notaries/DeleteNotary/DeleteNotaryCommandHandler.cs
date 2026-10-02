using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.DeleteNotary
{
    internal sealed class DeleteNotaryCommandHandler(
        INotaryRepository notaryRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteNotaryCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteNotaryCommand request, CancellationToken cancellationToken)
        {
            var notary = await notaryRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (notary is null)
            {
                return (500, "Noter bulunamadı");
            }

            notaryRepository.Delete(notary);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
