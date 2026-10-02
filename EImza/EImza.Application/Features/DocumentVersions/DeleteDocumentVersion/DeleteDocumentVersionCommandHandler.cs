using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.DocumentVersions.DeleteDocumentVersion
{
    internal sealed class DeleteDocumentVersionCommandHandler(
        IDocumentVersionRepository documentVersionRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteDocumentVersionCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteDocumentVersionCommand request, CancellationToken cancellationToken)
        {
            var documentVersion = await documentVersionRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (documentVersion is null)
            {
                return (500, "Doküman versiyonu bulunamadı");
            }

            documentVersionRepository.Delete(documentVersion);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
