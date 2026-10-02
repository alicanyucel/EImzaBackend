using MediatR;
using TS.Result;

namespace EImza.Application.Features.SignatureRequests.DeleteSignatureRequest
{
    public sealed record DeleteSignatureRequestCommand(Guid Id) : IRequest<Result<bool>>;
}
