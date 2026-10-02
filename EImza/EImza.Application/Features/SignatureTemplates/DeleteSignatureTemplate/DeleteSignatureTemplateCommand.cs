using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.DeleteSignatureTemplate
{
    public sealed record DeleteSignatureTemplateCommand(Guid Id) : IRequest<Result<bool>>;
}
