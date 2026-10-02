using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.DeleteNotary
{
    public sealed record DeleteNotaryCommand(Guid Id) : IRequest<Result<bool>>;
}
