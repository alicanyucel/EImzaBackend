using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureTemplates.DeleteSignatureTemplate
{
    internal sealed class DeleteSignatureTemplateCommandHandler(
        ISignatureTemplateRepository signatureTemplateRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteSignatureTemplateCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteSignatureTemplateCommand request, CancellationToken cancellationToken)
        {
            var signatureTemplate = await signatureTemplateRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (signatureTemplate is null)
            {
                return (500, "İmza şablonu bulunamadı");
            }

            signatureTemplateRepository.Delete(signatureTemplate);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
