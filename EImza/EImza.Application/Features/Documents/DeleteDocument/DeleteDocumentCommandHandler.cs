using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.DeleteDocument
{
    internal sealed class DeleteDocumentCommandHandler(
        IDocumentRepository documentRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteDocumentCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteDocumentCommand request, CancellationToken cancellationToken)
        {
            var document = await documentRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (document is null)
            {
                return (500, "Doküman bulunamadı");
            }

            documentRepository.Delete(document);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
