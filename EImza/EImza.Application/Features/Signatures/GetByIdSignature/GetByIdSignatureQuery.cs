using EImza.Domain.Entities;
using MediatR;
using TS.Result;
using SignatureEntity = EImza.Domain.Entities.Signature;

namespace EImza.Application.Features.Signatures.GetByIdSignature
{
    public sealed record GetByIdSignatureQuery(Guid Id) : IRequest<Result<SignatureEntity>>;
}
