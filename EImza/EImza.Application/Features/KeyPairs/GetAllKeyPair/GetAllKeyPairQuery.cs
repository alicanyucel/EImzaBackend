using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.KeyPairs.GetAllKeyPair
{
    public sealed record GetAllKeyPairQuery() : IRequest<Result<List<KeyPair>>>;
}
