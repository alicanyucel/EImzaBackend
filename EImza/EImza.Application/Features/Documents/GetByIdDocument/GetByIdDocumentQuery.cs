using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.GetByIdDocument
{
    public sealed record GetByIdDocumentQuery(Guid Id) : IRequest<Result<Document>>;
}
