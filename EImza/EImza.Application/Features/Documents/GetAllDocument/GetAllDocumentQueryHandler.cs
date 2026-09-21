using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.Documents.GetAllDocument
{
    internal sealed class GetAllDocumentQueryHandler(
        IDocumentRepository documentRepository) : IRequestHandler<GetAllDocumentQuery, Result<List<Document>>>
    {
        public async Task<Result<List<Document>>> Handle(GetAllDocumentQuery request, CancellationToken cancellationToken)
        {
            var documents = await documentRepository.GetAll()
                .Where(p => !p.IsDeleted)
                .OrderByDescending(p => p.UploadedAt)
                .ToListAsync(cancellationToken);

            return documents;
        }
    }
}
