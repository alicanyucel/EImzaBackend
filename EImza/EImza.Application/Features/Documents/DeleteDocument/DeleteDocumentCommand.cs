using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.DeleteDocument
{
    public sealed record DeleteDocumentCommand(Guid Id) : IRequest<Result<bool>>;
}
