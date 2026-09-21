using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.CreateDocument
{
    internal sealed class CreateDocumentCommandHandler(
        IDocumentRepository documentRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateDocumentCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
        {
            var document = new Document
            {
                FileName = request.FileName,
                ContentType = request.ContentType,
                Size = request.Size,
                UploadedByUserId = request.UploadedByUserId,
                UploadedAt = DateTime.UtcNow,
                IsDeleted = false
            };

            await documentRepository.AddAsync(document, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return document.Id;
        }
    }
}
