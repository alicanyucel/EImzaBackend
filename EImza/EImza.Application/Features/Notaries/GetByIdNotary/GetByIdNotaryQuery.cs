using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.GetByIdNotary
{
    public sealed record GetByIdNotaryQuery(Guid Id) : IRequest<Result<Notary>>;
}
