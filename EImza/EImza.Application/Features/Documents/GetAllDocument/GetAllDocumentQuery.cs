using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.GetAllDocument
{
    public sealed record GetAllDocumentQuery() : IRequest<Result<List<Document>>>;
}
