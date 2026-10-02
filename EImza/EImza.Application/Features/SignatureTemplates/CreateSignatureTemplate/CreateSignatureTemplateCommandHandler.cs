using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.CreateSignatureTemplate
{
    internal sealed class CreateSignatureTemplateCommandHandler(
        ISignatureTemplateRepository signatureTemplateRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateSignatureTemplateCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateSignatureTemplateCommand request, CancellationToken cancellationToken)
        {
            var signatureTemplate = new SignatureTemplate
            {
                Name = request.Name,
                Description = request.Description,
                JsonDefinition = request.JsonDefinition,
                CreatedByUserId = request.CreatedByUserId,
                CreatedAt = DateTime.UtcNow
            };

            await signatureTemplateRepository.AddAsync(signatureTemplate, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return signatureTemplate.Id;
        }
    }
}
