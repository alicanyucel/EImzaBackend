using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.GetAllDocumentVersion
{
    public sealed record GetAllDocumentVersionQuery() : IRequest<Result<List<DocumentVersion>>>;
}
