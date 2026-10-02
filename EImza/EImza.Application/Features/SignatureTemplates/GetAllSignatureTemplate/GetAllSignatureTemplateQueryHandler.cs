using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.GetAllSignatureTemplate
{
    internal sealed class GetAllSignatureTemplateQueryHandler(
        ISignatureTemplateRepository signatureTemplateRepository) : IRequestHandler<GetAllSignatureTemplateQuery, Result<List<SignatureTemplate>>>
    {
        public async Task<Result<List<SignatureTemplate>>> Handle(GetAllSignatureTemplateQuery request, CancellationToken cancellationToken)
        {
            var signatureTemplates = await signatureTemplateRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return signatureTemplates;
        }
    }
}
