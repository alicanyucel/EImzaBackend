using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.GetByIdSignatureTemplate
{
    public sealed record GetByIdSignatureTemplateQuery(Guid Id) : IRequest<Result<SignatureTemplate>>;
}
