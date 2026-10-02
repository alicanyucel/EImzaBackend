using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SigningSessions.DeleteSigningSession
{
    internal sealed class DeleteSigningSessionCommandHandler(
        ISigningSessionRepository signingSessionRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteSigningSessionCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteSigningSessionCommand request, CancellationToken cancellationToken)
        {
            var signingSession = await signingSessionRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signingSession is null)
            {
                return (500, "İmza oturumu bulunamadı");
            }

            signingSessionRepository.Delete(signingSession);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
