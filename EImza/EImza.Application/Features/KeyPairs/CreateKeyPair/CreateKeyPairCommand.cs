using MediatR;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.CreateKeyPair
{
    public sealed record CreateKeyPairCommand(
        Guid OwnerId,
        string KeyType,
        string PublicKey,
        string? EncryptedPrivateKey) : IRequest<Result<Guid>>;
}
