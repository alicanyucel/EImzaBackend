using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.ValidationResults.GetAllValidationResult
{
    internal sealed class GetAllValidationResultQueryHandler(
        IValidationResultRepository validationResultRepository) : IRequestHandler<GetAllValidationResultQuery, Result<List<ValidationResult>>>
    {
        public async Task<Result<List<ValidationResult>>> Handle(GetAllValidationResultQuery request, CancellationToken cancellationToken)
        {
            var validationResults = await validationResultRepository.GetAll()
                .OrderByDescending(p => p.CheckedAt)
                .ToListAsync(cancellationToken);

            return validationResults;
        }
    }
}
