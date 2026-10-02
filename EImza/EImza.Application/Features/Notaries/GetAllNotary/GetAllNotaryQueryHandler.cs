using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.Notaries.GetAllNotary
{
    internal sealed class GetAllNotaryQueryHandler(
        INotaryRepository notaryRepository) : IRequestHandler<GetAllNotaryQuery, Result<List<Notary>>>
    {
        public async Task<Result<List<Notary>>> Handle(GetAllNotaryQuery request, CancellationToken cancellationToken)
        {
            var notaries = await notaryRepository.GetAll()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            return notaries;
        }
    }
}
