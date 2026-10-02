using MediatR;
using TS.Result;

namespace EImza.Application.Features.Signatures.DeleteSignature
{
    public sealed record DeleteSignatureCommand(Guid Id) : IRequest<Result<bool>>;
}
