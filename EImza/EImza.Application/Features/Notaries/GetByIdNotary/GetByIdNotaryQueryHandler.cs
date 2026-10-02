using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.GetByIdNotary
{
    internal sealed class GetByIdNotaryQueryHandler(
        INotaryRepository notaryRepository) : IRequestHandler<GetByIdNotaryQuery, Result<Notary>>
    {
        public async Task<Result<Notary>> Handle(GetByIdNotaryQuery request, CancellationToken cancellationToken)
        {
            var notary = await notaryRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (notary is null)
            {
                return (500, "Noter bulunamadı");
            }

            return notary;
        }
    }
}
