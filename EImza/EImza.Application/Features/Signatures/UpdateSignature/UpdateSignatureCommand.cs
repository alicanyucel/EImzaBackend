using MediatR;
using TS.Result;

namespace EImza.Application.Features.Signatures.UpdateSignature
{
    public sealed record UpdateSignatureCommand(
        Guid Id,
        string Status,
        string? Reason) : IRequest<Result<bool>>;
}
