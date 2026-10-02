using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.GetByIdDocumentVersion
{
    internal sealed class GetByIdDocumentVersionQueryHandler(
        IDocumentVersionRepository documentVersionRepository) : IRequestHandler<GetByIdDocumentVersionQuery, Result<DocumentVersion>>
    {
        public async Task<Result<DocumentVersion>> Handle(GetByIdDocumentVersionQuery request, CancellationToken cancellationToken)
        {
            var documentVersion = await documentVersionRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (documentVersion is null)
            {
                return (500, "Doküman versiyonu bulunamadı");
            }

            return documentVersion;
        }
    }
}
