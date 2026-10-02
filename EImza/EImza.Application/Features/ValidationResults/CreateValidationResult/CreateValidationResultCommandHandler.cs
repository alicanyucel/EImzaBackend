using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ValidationResults.CreateValidationResult
{
    internal sealed class CreateValidationResultCommandHandler(
        IValidationResultRepository validationResultRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateValidationResultCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateValidationResultCommand request, CancellationToken cancellationToken)
        {
            var validationResult = new ValidationResult
            {
                SignatureId = request.SignatureId,
                IsValid = request.IsValid,
                Details = request.Details,
                CheckedAt = DateTime.UtcNow
            };

            await validationResultRepository.AddAsync(validationResult, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return validationResult.Id;
        }
    }
}
