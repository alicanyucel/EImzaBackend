using MediatR;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.DeleteKeyPair
{
    public sealed record DeleteKeyPairCommand(Guid Id) : IRequest<Result<bool>>;
}
