using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.ValidationResults.GetAllValidationResult
{
    public sealed record GetAllValidationResultQuery() : IRequest<Result<List<ValidationResult>>>;
}
