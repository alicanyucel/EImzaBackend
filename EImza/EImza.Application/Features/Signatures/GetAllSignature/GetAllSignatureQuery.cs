using EImza.Domain.Entities;
using MediatR;
using TS.Result;
using SignatureEntity = EImza.Domain.Entities.Signature;

namespace EImza.Application.Features.Signatures.GetAllSignature
{
    public sealed record GetAllSignatureQuery() : IRequest<Result<List<SignatureEntity>>>;
}
