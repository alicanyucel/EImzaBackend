using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.TimestampTokens.GetAllTimestampToken
{
    internal sealed class GetAllTimestampTokenQueryHandler(
        ITimestampTokenRepository timestampTokenRepository) : IRequestHandler<GetAllTimestampTokenQuery, Result<List<TimestampToken>>>
    {
        public async Task<Result<List<TimestampToken>>> Handle(GetAllTimestampTokenQuery request, CancellationToken cancellationToken)
        {
            var timestampTokens = await timestampTokenRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return timestampTokens;
        }
    }
}
