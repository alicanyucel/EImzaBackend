using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.CreateNotary
{
    internal sealed class CreateNotaryCommandHandler(
        INotaryRepository notaryRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateNotaryCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateNotaryCommand request, CancellationToken cancellationToken)
        {
            var notary = new Notary
            {
                Name = request.Name,
                RegistrationNumber = request.RegistrationNumber,
                Contact = request.Contact
            };

            await notaryRepository.AddAsync(notary, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return notary.Id;
        }
    }
}
