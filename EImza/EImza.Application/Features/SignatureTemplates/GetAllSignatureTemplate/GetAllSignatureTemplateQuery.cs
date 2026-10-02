using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.GetAllSignatureTemplate
{
    public sealed record GetAllSignatureTemplateQuery() : IRequest<Result<List<SignatureTemplate>>>;
}
