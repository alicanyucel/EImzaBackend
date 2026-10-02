using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ValidationResults.GetByIdValidationResult
{
    internal sealed class GetByIdValidationResultQueryHandler(
        IValidationResultRepository validationResultRepository) : IRequestHandler<GetByIdValidationResultQuery, Result<ValidationResult>>
    {
        public async Task<Result<ValidationResult>> Handle(GetByIdValidationResultQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await validationResultRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (validationResult is null)
            {
                return (500, "Doğrulama sonucu bulunamadı");
            }

            return validationResult;
        }
    }
}
