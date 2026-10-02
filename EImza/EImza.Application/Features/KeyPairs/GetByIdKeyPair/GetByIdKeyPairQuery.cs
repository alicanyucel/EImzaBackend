using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.GetByIdKeyPair
{
    public sealed record GetByIdKeyPairQuery(Guid Id) : IRequest<Result<KeyPair>>;
}
