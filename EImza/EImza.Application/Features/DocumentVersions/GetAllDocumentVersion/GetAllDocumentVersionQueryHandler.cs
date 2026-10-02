using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.GetAllDocumentVersion
{
    internal sealed class GetAllDocumentVersionQueryHandler(
        IDocumentVersionRepository documentVersionRepository) : IRequestHandler<GetAllDocumentVersionQuery, Result<List<DocumentVersion>>>
    {
        public async Task<Result<List<DocumentVersion>>> Handle(GetAllDocumentVersionQuery request, CancellationToken cancellationToken)
        {
            var documentVersions = await documentVersionRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return documentVersions;
        }
    }
}
