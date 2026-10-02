using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.CreateSignatureTemplate
{
    public sealed record CreateSignatureTemplateCommand(
        string Name,
        string Description,
        string JsonDefinition,
        Guid CreatedByUserId) : IRequest<Result<Guid>>;
}
