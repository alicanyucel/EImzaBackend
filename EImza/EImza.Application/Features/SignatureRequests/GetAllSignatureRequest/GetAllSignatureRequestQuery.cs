using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.GetAllSignatureRequest
{
    public sealed record GetAllSignatureRequestQuery() : IRequest<Result<List<SignatureRequest>>>;
}
