using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Documents.UpdateDocument
{
    internal sealed class UpdateDocumentCommandHandler(
        IDocumentRepository documentRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateDocumentCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
        {
            var document = await documentRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (document is null)
            {
                return (500, "Doküman bulunamadı");
            }

            document.FileName = request.FileName;
            document.ContentType = request.ContentType;
            document.Size = request.Size;
            document.IsDeleted = request.IsDeleted;

            documentRepository.Update(document);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
