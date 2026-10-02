using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.GetByIdSignatureRequest
{
    public sealed record GetByIdSignatureRequestQuery(Guid Id) : IRequest<Result<SignatureRequest>>;
}
