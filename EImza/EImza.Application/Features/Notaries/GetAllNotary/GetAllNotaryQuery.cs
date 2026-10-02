using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Notaries.GetAllNotary
{
    public sealed record GetAllNotaryQuery() : IRequest<Result<List<Notary>>>;
}
