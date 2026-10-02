using MediatR;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.DeleteDocumentVersion
{
    public sealed record DeleteDocumentVersionCommand(Guid Id) : IRequest<Result<bool>>;
}
