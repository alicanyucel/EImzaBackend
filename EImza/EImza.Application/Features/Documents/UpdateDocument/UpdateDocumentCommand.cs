using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.UpdateDocument
{
    public sealed record UpdateDocumentCommand(
        Guid Id,
        string FileName,
        string ContentType,
        long Size,
        bool IsDeleted) : IRequest<Result<bool>>;
}
