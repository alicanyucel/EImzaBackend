using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.UpdateNotary
{
    internal sealed class UpdateNotaryCommandHandler(
        INotaryRepository notaryRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateNotaryCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateNotaryCommand request, CancellationToken cancellationToken)
        {
            var notary = await notaryRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (notary is null)
            {
                return (500, "Noter bulunamadı");
            }

            notary.Name = request.Name;
            notary.RegistrationNumber = request.RegistrationNumber;
            notary.Contact = request.Contact;

            notaryRepository.Update(notary);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
