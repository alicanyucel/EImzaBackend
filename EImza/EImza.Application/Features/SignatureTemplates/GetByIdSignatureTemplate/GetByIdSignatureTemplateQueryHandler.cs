using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.GetByIdSignatureTemplate
{
    internal sealed class GetByIdSignatureTemplateQueryHandler(
        ISignatureTemplateRepository signatureTemplateRepository) : IRequestHandler<GetByIdSignatureTemplateQuery, Result<SignatureTemplate>>
    {
        public async Task<Result<SignatureTemplate>> Handle(GetByIdSignatureTemplateQuery request, CancellationToken cancellationToken)
        {
            var signatureTemplate = await signatureTemplateRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signatureTemplate is null)
            {
                return (500, "İmza şablonu bulunamadı");
            }

            return signatureTemplate;
        }
    }
}
