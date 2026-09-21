using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.GetByIdDocument
{
    internal sealed class GetByIdDocumentQueryHandler(
        IDocumentRepository documentRepository) : IRequestHandler<GetByIdDocumentQuery, Result<Document>>
    {
        public async Task<Result<Document>> Handle(GetByIdDocumentQuery request, CancellationToken cancellationToken)
        {
            var document = await documentRepository.GetByExpressionAsync(p => p.Id == request.Id && !p.IsDeleted, cancellationToken);

            if (document is null)
            {
                return (500, "Doküman bulunamadı");
            }

            return document;
        }
    }
}
