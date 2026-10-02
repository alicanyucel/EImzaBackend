using MediatR;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.CreateDocumentVersion
{
    public sealed record CreateDocumentVersionCommand(
        Guid DocumentId,
        int VersionNumber,
        string BlobStoragePath,
        Guid CreatedByUserId) : IRequest<Result<Guid>>;
}
