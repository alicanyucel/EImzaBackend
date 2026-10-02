using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.CreateTimestampToken
{
    internal sealed class CreateTimestampTokenCommandHandler(
        ITimestampTokenRepository timestampTokenRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateTimestampTokenCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateTimestampTokenCommand request, CancellationToken cancellationToken)
        {
            var timestampToken = new TimestampToken
            {
                TokenBase64 = request.TokenBase64,
                CreatedByUserId = request.CreatedByUserId,
                DocumentId = request.DocumentId,
                CreatedAt = DateTime.UtcNow
            };

            await timestampTokenRepository.AddAsync(timestampToken, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return timestampToken.Id;
        }
    }
}
