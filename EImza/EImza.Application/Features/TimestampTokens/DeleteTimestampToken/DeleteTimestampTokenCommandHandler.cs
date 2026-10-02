using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.DeleteTimestampToken
{
    internal sealed class DeleteTimestampTokenCommandHandler(
        ITimestampTokenRepository timestampTokenRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteTimestampTokenCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteTimestampTokenCommand request, CancellationToken cancellationToken)
        {
            var timestampToken = await timestampTokenRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (timestampToken is null)
            {
                return (500, "Zaman damgası bulunamadı");
            }

            timestampTokenRepository.Delete(timestampToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
