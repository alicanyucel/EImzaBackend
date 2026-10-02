using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.GetByIdTimestampToken
{
    internal sealed class GetByIdTimestampTokenQueryHandler(
        ITimestampTokenRepository timestampTokenRepository) : IRequestHandler<GetByIdTimestampTokenQuery, Result<TimestampToken>>
    {
        public async Task<Result<TimestampToken>> Handle(GetByIdTimestampTokenQuery request, CancellationToken cancellationToken)
        {
            var timestampToken = await timestampTokenRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (timestampToken is null)
            {
                return (500, "Zaman damgası bulunamadı");
            }

            return timestampToken;
        }
    }
}
