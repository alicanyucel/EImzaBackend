using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.GetByIdDocumentVersion
{
    public sealed record GetByIdDocumentVersionQuery(Guid Id) : IRequest<Result<DocumentVersion>>;
}
