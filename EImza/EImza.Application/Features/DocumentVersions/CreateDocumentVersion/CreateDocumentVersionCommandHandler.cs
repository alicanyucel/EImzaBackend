using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.CreateDocumentVersion
{
    internal sealed class CreateDocumentVersionCommandHandler(
        IDocumentVersionRepository documentVersionRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateDocumentVersionCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateDocumentVersionCommand request, CancellationToken cancellationToken)
        {
            var documentVersion = new DocumentVersion
            {
                DocumentId = request.DocumentId,
                VersionNumber = request.VersionNumber,
                BlobStoragePath = request.BlobStoragePath,
                CreatedAt = DateTime.UtcNow,
                CreatedByUserId = request.CreatedByUserId
            };

            await documentVersionRepository.AddAsync(documentVersion, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return documentVersion.Id;
        }
    }
}
