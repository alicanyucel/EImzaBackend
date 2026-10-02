using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ValidationResults.GetByIdValidationResult
{
    public sealed record GetByIdValidationResultQuery(Guid Id) : IRequest<Result<ValidationResult>>;
}
