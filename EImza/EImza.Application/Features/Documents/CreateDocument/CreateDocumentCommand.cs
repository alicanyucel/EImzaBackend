using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.CreateDocument
{
    public sealed record CreateDocumentCommand(
        string FileName,
        string ContentType,
        long Size,
        Guid UploadedByUserId) : IRequest<Result<Guid>>;
}
