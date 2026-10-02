using MediatR;
using TS.Result;

namespace EImza.Application.Features.ValidationResults.CreateValidationResult
{
    public sealed record CreateValidationResultCommand(
        Guid SignatureId,
        bool IsValid,
        string Details) : IRequest<Result<Guid>>;
}
